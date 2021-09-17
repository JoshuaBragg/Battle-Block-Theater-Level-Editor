using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;	
using System.IO;
using System.Text.RegularExpressions;


namespace BattleBlockCustom
{
    public partial class Window : Form
    {
		private PictureBox[,] imageGrid;
		private PictureBox blockPreview;
		private PictureBox bg;
		private PictureBox sbg;
		private string[] hexParam;
		private string[] hexLevel;

		private Dictionary<int, string> hexMap = new Dictionary<int, string>();

		public Window()
        {
            InitializeComponent();

			try
			{
				// Create hexMap Dictionary containing the sprite locations
				setupHexMap();

				// Create blockPreview
				blockPreview = new PictureBox
				{
					Size = new Size(25, 20),
					Location = new Point(700, 42),
					SizeMode = PictureBoxSizeMode.StretchImage,
					Image = hexMap.ContainsKey(int.Parse(placeBlockValTextbox.Text)) ? Image.FromFile(hexMap[int.Parse(placeBlockValTextbox.Text)]) : Image.FromFile(hexMap[256])
				};

				this.Controls.Add(blockPreview);
			}
			catch (FileNotFoundException ex)
			{
				// Display messagebox so the user knows that error occurred
				MessageBox.Show("Required files not found. Make sure this executable is in the same folder as all resources!" 
					+ Environment.NewLine + Environment.NewLine + "Error: " + ex.Message.Remove(ex.Message.Length - 1) + " could not be found",
					"Program cannot open | ERROR");
				
				// End program
				throw;
			}
		}

		/// <summary>
		/// Opens and interprets images.txt Takes this data and sets up the Dictionary hexMap
		/// </summary>
		private void setupHexMap()
		{
			// Open the text file using a stream reader. Parse strings to create the image hexMap
			using (StreamReader sr = new StreamReader("images.txt"))
			{
				string line = sr.ReadToEnd();
				string[] lines = line.Split('\n');
				foreach (string s in lines)
				{
					string[] currLine = s.Split(',');
					hexMap.Add(Convert.ToInt32(currLine[0], 16), currLine[1]);
				}
			}
		}

		/// <summary>
		/// Reads binary data from file and interprets the file data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void openFile_Click(object sender, EventArgs e)
		{
			// Opens file and ensures that the file opened does not have a period in its name
			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				// Prevents misclick of a file that has an extension
				if (Regex.IsMatch(openFileDialog.FileName, "\\."))
				{
					MessageBox.Show("The file you attempted to open had an extension. This file was probably not a BattleBlock Theater level file because of its extension.",
					"Open file cancellation | ERROR");
					return;
				}

				// Prevents misclicks since trying to open a large file can be bad
				if (new FileInfo(openFileDialog.FileName).Length > 2000)
				{
					MessageBox.Show("The file you attempted to open was too large. This file was probably not a BattleBlock Theater level file because of its size.",
					"Open file cancellation | ERROR");
					return;
				}

				// Resets gui variables
				imageGrid = default(PictureBox[,]);
				hexParam = default(string[]);
				hexLevel = default(string[]);
				levelPanel.Controls.Clear();

				BinaryReader br = new BinaryReader(File.OpenRead(openFileDialog.FileName));

				string[] hexData = new string[16];
				string[] hexDataRaw = new string[16];
				int c = 0;

				// Reads the parameter data
				for (int i = 0x0; i <= 0xF; i++)
				{
					byte b = br.ReadByte();
					hexData[c] = b.ToString();
					hexDataRaw[c++] = b.ToString("X2");
				}

				int end = int.Parse(hexData[1]) * int.Parse(hexData[2]);

				string[] hexDataLevel = new string[end];
				string[] hexDataLevelRaw = new string[end];
				c = 0;

				// Reads the level data
				for (int i = 0x10; i < end+16; i++)
				{
					byte b = br.ReadByte();
					hexDataLevel[c] = b.ToString();
					hexDataLevelRaw[c++] = b.ToString("X2");
				}

				br.Close();

				hexParam = hexDataRaw;
				hexLevel = hexDataLevelRaw;

				// initializes the level grid on right
				imageGrid = new PictureBox[int.Parse(hexData[2]), int.Parse(hexData[1])];
				initLevelGrid(int.Parse(hexData[2]), int.Parse(hexData[1]), hexDataLevel);

				// updates textboxes for parameters
				levelWidthTextbox.Text = hexData[1];
				levelHeightTextbox.Text = hexData[2];
				gameModeTextbox.Text = hexData[3];
				blockStyleTextbox.Text = hexData[4];
				skyColourTextbox.Text = hexData[5];
				bgStyleTextbox.Text = hexData[6];
				specialFGTextbox.Text = hexData[7];
				specialBGTextbox.Text = hexData[8];
				block1ColourTextbox.Text = hexData[9];
				block2ColourTextbox.Text = hexData[10];
				waterColourTextbox.Text = hexData[11];
				plantColourTextbox.Text = hexData[12];
				levelTimeTextbox.Text = hexData[14];

				// Updates the Raw Hex Data text field
				updateHexDataButton.PerformClick();
			}
		}

		/// <summary>
		/// Writes data from hexParam and hexLevel to file selected
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void saveFile_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				// Makes sure we have data to write
				if (hexParam == default(string[]) || hexLevel == default(string[]))
				{
					MessageBox.Show("There is no data to write.", "Save file cancellation | ERROR");
					return;
				}

				BinaryWriter bw = new BinaryWriter(File.OpenWrite(saveFileDialog.FileName));

				// Writes parameters
				for (int i = 0x0; i <= 0xF; i++)
				{
					bw.BaseStream.Position = i;
					bw.Write(Convert.ToInt32(hexParam[i], 16));
				}

				int end = Convert.ToInt32(hexParam[1], 16) * Convert.ToInt32(hexParam[2], 16);

				// Writes level data
				for (int i = 0x0; i < end; i++)
				{
					bw.BaseStream.Position = i+0x10;
					bw.Write(Convert.ToInt32(hexLevel[i], 16));
				}

				bw.Close();
			}
		}

		/// <summary>
		/// Checks that parameters are valid and updates hex data and level display accordingly
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void updateParamButton_Click(object sender, EventArgs e)
		{
			// Checks each of the parameter textboxes and verifies that the number is within the correct range
			textboxValidate(levelWidthTextbox, 15, 15, 40, 40, 25);
			textboxValidate(levelHeightTextbox, 10, 10, 30, 30, 20);
			textboxValidate(gameModeTextbox, 0, 0, 8, 0, 0);
			textboxValidate(blockStyleTextbox, 0, 0, 16, 16, 0);
			textboxValidate(skyColourTextbox, 0, 0, 29, 29, 0);
			textboxValidate(bgStyleTextbox, 0, 0, 22, 22, 0);
			textboxValidate(specialFGTextbox, 0, 0, 44, 44, 0);
			textboxValidate(specialBGTextbox, 0, 0, 43, 0, 0);
			textboxValidate(block1ColourTextbox, 0, 0, 33, 33, 0);
			textboxValidate(block2ColourTextbox, 0, 0, 33, 33, 0);
			textboxValidate(waterColourTextbox, 0, 0, 33, 33, 0);
			textboxValidate(plantColourTextbox, 0, 0, 33, 33, 0);
			textboxValidate(levelTimeTextbox, 0, 0, 255, 255, 45);

			if (hexParam == default(string[]))
			{
				return;
			}

			// Updates hexParam with updated data
			hexParam[1] = int.Parse(levelWidthTextbox.Text).ToString("X2");
			hexParam[2] = int.Parse(levelHeightTextbox.Text).ToString("X2");
			hexParam[3] = int.Parse(gameModeTextbox.Text).ToString("X2");
			hexParam[4] = int.Parse(blockStyleTextbox.Text).ToString("X2");
			hexParam[5] = int.Parse(skyColourTextbox.Text).ToString("X2");
			hexParam[6] = int.Parse(bgStyleTextbox.Text).ToString("X2");
			hexParam[7] = int.Parse(specialFGTextbox.Text).ToString("X2");
			hexParam[8] = int.Parse(specialBGTextbox.Text).ToString("X2");
			hexParam[9] = int.Parse(block1ColourTextbox.Text).ToString("X2");
			hexParam[10] = int.Parse(block2ColourTextbox.Text).ToString("X2");
			hexParam[11] = int.Parse(waterColourTextbox.Text).ToString("X2");
			hexParam[12] = int.Parse(plantColourTextbox.Text).ToString("X2");
			hexParam[14] = int.Parse(levelTimeTextbox.Text).ToString("X2");

			// Redraws the level preview
			levelPanel.Controls.Clear();
			initLevelGrid(int.Parse(levelHeightTextbox.Text), int.Parse(levelWidthTextbox.Text));
		}

		/// <summary>
		/// Validates that the text within the 'textbox' is valid
		/// </summary>
		/// <param name="textbox">The textbox to check</param>
		/// <param name="lowerBound">The lower bound of a valid value in this box</param>
		/// <param name="lowerValue">The value this box is set to if it was below the lowerBound</param>
		/// <param name="upperBound">The upper bound of a valid value in this box</param>
		/// <param name="upperValue">The value this box is set to if it was above the upperBound</param>
		/// <param name="defaultValue">The value the box should be set to if the value was not an integer</param>
		private void textboxValidate(Control textbox, int lowerBound, int lowerValue, int upperBound, int upperValue, int defaultValue)
		{
			if (int.TryParse(textbox.Text, out int n))
			{
				int text = int.Parse(textbox.Text);
				if (text < lowerBound)
				{
					textbox.Text = lowerValue.ToString();
				}
				else if (text > upperBound)
				{
					textbox.Text = upperValue.ToString();
				}
			}
			else
			{
				textbox.Text = defaultValue.ToString();
			}
		}

		/// <summary>
		/// Gets the hexMap key for the current BGStyle
		/// </summary>
		/// <returns>hexMap key</returns>
		private int getBGStyle()
		{
			return Convert.ToInt32(hexParam[6], 16) + 0x110;
		}

		/// <summary>
		/// Gets the hexMap key for the current SBGStyle
		/// </summary>
		/// <returns>hexMap key</returns>
		private int getSBGStyle()
		{
			return Convert.ToInt32(hexParam[8], 16) + 0x130;
		}

		/// <summary>
		/// Will check the placeBlockValTextbox to make sure its an int also updates block preview
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void placeBlockValTextbox_TextChanged(object sender, EventArgs e)
		{
			// Makes sure you type an int
			if (!int.TryParse(placeBlockValTextbox.Text, out int n))
			{
				placeBlockValTextbox.Text = placeBlockValTextbox.Text.Length - 1 > 0 ? placeBlockValTextbox.Text.Substring(0, placeBlockValTextbox.Text.Length - 1) : "0";
			}

			blockPreview.Image = hexMap.ContainsKey(int.Parse(placeBlockValTextbox.Text)) ? Image.FromFile(hexMap[int.Parse(placeBlockValTextbox.Text)]) : Image.FromFile(hexMap[256]);
		}

		/// <summary>
		/// Creates level grid when reading from levelData
		/// </summary>
		/// <param name="h">level height</param>
		/// <param name="w">level width</param>
		/// <param name="levelData">the block data</param>
		private void initLevelGrid(int h, int w, string[] levelData)
		{
			int availW = levelPanel.Width - 10;
			int availH = (int)Math.Round(levelPanel.Height * 1.25) - 20;
			int imageSizeX = availW / w < availH / h ? availW / w : availH / h;
			int imageSizeY = (int)Math.Round(imageSizeX * 0.8);
			int shiftx = (levelPanel.Width - (imageSizeX * w)) / 2;
			int shifty = (levelPanel.Height - (imageSizeY * h)) / 2;

			bg = new PictureBox
			{
				Size = new Size(w * imageSizeX, h * imageSizeY),
				Location = new Point(shiftx, shifty),
				Text =  enableBGCheckbox.Checked ? hexMap[getBGStyle()] : "res/bgSprites/bg.png",
				SizeMode = PictureBoxSizeMode.StretchImage,
				Image = enableBGCheckbox.Checked ? Image.FromFile(hexMap[getBGStyle()]) : Image.FromFile("res/bgSprites/bg.png")
			};

			sbg = new PictureBox
			{
				Size = new Size(w * imageSizeX, h * imageSizeY),
				Location = new Point(0, 0),
				Text = enableBGCheckbox.Checked ? hexMap[getSBGStyle()] : "res/bgSprites/bg.png",
				SizeMode = PictureBoxSizeMode.StretchImage,
				BackColor = Color.Transparent,
				Image = enableBGCheckbox.Checked ? Image.FromFile(hexMap[getSBGStyle()]) : Image.FromFile("res/bgSprites/bg.png")
			};

			for (int r = 0; r < imageGrid.GetLength(0); r++)
			{
				for (int c = 0; c < imageGrid.GetLength(1); c++)
				{
					PictureBox pBox = new PictureBox
					{
						Size = new Size(imageSizeX, imageSizeY),
						Location = new Point(imageSizeX * c, imageSizeY * r),
						Text = levelData[c + w * r],
						Tag = r + "," + c,
						SizeMode = PictureBoxSizeMode.StretchImage,
						BackColor = Color.Transparent,
						Image = hexMap.ContainsKey(int.Parse(levelData[c + w * r])) ? Image.FromFile(hexMap[int.Parse(levelData[c + w * r])]) : Image.FromFile(hexMap[256])
					};
					pBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.levelPanel_MouseDown);
					imageGrid[r, c] = pBox;
					sbg.Controls.Add(imageGrid[r, c]);
				}
			}

			bg.Controls.Add(sbg);
			levelPanel.Controls.Add(bg);
		}

		/// <summary>
		/// Initializing level grid if size has changed
		/// </summary>
		/// <param name="h">level height</param>
		/// <param name="w">level width</param>
		private void initLevelGrid(int h, int w)
		{
			int availW = levelPanel.Width - 10;
			int availH = (int)Math.Round(levelPanel.Height * 1.25) - 20;
			int imageSizeX = availW / w < availH / h ? availW / w : availH / h;
			int imageSizeY = (int)Math.Round(imageSizeX * 0.8);
			int shiftx = (levelPanel.Width - (imageSizeX * w)) / 2;
			int shifty = (levelPanel.Height - (imageSizeY * h)) / 2;

			PictureBox[,] newGrid = new PictureBox[h, w];
			string[] hexLevelNew = new string[w * h];

			bg = new PictureBox
			{
				Size = new Size(w * imageSizeX, h * imageSizeY),
				Location = new Point(shiftx, shifty),
				Text = enableBGCheckbox.Checked ? hexMap[getBGStyle()] : "res/bgSprites/bg.png",
				SizeMode = PictureBoxSizeMode.StretchImage,
				Image = enableBGCheckbox.Checked ? Image.FromFile(hexMap[getBGStyle()]) : Image.FromFile("res/bgSprites/bg.png")
			};

			sbg = new PictureBox
			{
				Size = new Size(w * imageSizeX, h * imageSizeY),
				Location = new Point(0, 0),
				Text = enableBGCheckbox.Checked ? hexMap[getSBGStyle()] : "res/bgSprites/bg.png",
				SizeMode = PictureBoxSizeMode.StretchImage,
				BackColor = Color.Transparent,
				Image = enableBGCheckbox.Checked ? Image.FromFile(hexMap[getSBGStyle()]) : Image.FromFile("res/bgSprites/bg.png")
			};

			for (int r = 0; r < h; r++)
			{
				for (int c = 0; c < w; c++)
				{
					if (r >= imageGrid.GetLength(0) || c >= imageGrid.GetLength(1))
					{
						PictureBox pBox = new PictureBox
						{
							Size = new Size(imageSizeX, imageSizeY),
							Location = new Point(imageSizeX * c, imageSizeY * r),
							Text = "0",
							Tag = r + "," + c,
							SizeMode = PictureBoxSizeMode.StretchImage,
							BackColor = Color.Transparent,
							Image = Image.FromFile(hexMap[0])
						};
						pBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.levelPanel_MouseDown);
						newGrid[r, c] = pBox;
						hexLevelNew[c + w * r] = int.Parse(pBox.Text).ToString("X2");
					}
					else
					{
						PictureBox pBox = imageGrid[r, c];
						pBox.Size = new Size(imageSizeX, imageSizeY);
						pBox.Location = new Point(imageSizeX * c, imageSizeY * r);
						pBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.levelPanel_MouseDown);
						newGrid[r, c] = pBox;
						hexLevelNew[c + w * r] = int.Parse(pBox.Text).ToString("X2");
					}
					sbg.Controls.Add(newGrid[r, c]);
				}
			}

			hexLevel = hexLevelNew;
			imageGrid = newGrid;

			bg.Controls.Add(sbg);
			levelPanel.Controls.Add(bg);
		}

		/// <summary>
		/// Handles mouseDown events, updates the blocks if event occured on grid
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void levelPanel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			switch (e.Button)
			{
				case MouseButtons.Left:
					updatePicBox((PictureBox)sender);
					break;
				case MouseButtons.Right:
					((PictureBox)sender).Text = "0";
					((PictureBox)sender).Image = Image.FromFile(hexMap[int.Parse("0")]);
					string[] coor = ((String)((PictureBox)sender).Tag).Split(',');
					hexLevel[int.Parse(coor[1]) + Convert.ToInt32(hexParam[1], 16) * int.Parse(coor[0])] = "00";
					break;
			}
		}

		/// <summary>
		/// Updates the picture within p
		/// </summary>
		/// <param name="p"></param>
		private void updatePicBox(PictureBox p)
		{
			p.Text = placeBlockValTextbox.Text;
			if (hexMap.ContainsKey(int.Parse(p.Text)))
			{
				p.Image = Image.FromFile(hexMap[int.Parse(p.Text)]);
				string[] coor = ((String)p.Tag).Split(',');
				hexLevel[int.Parse(coor[1]) + Convert.ToInt32(hexParam[1], 16) * int.Parse(coor[0])] = int.Parse(p.Text).ToString("X2");
			}
			else
			{
				p.Image = Image.FromFile(hexMap[256]);
				string[] coor = ((String)p.Tag).Split(',');
				hexLevel[int.Parse(coor[1]) + Convert.ToInt32(hexParam[1], 16) * int.Parse(coor[0])] = "FF";
			}
		}

		/// <summary>
		/// Reprints the 'Raw Hex Data' field with level data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void updateHexDataButton_Click(object sender, EventArgs e)
		{
			fileData.Text = "";

			// Make sure we have data to write to fileData
			if (hexParam == default(string[]) || hexLevel == default(string[]))
			{
				return;
			}

			// updates the textbox containing the hex data with ParamData
			foreach (string hx in hexParam)
			{
				fileData.Text += hx + " ";
			}

			// updates the textbox containing the hex data LevelData
			for (int i = 0; i < hexLevel.Length; i++)
			{
				if (i % (easyHexCheckbox.Checked ? Convert.ToInt32(hexParam[1], 16) : 16) == 0)
				{
					fileData.Text += Environment.NewLine;
				}
				fileData.Text += hexLevel[i] + " ";
			}
		}

		/// <summary>
		/// Opens Help window
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void helpButton_Click(object sender, EventArgs e)
		{
			new Help().Show();
		}

		/// <summary>
		/// If the redraws level preview if a file has been loaded
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void enableBGCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			if (hexParam != default(string[]))
			{
				levelPanel.Controls.Clear();
				initLevelGrid(Convert.ToInt32(hexParam[2], 16), Convert.ToInt32(hexParam[1], 16));
			}
		}
	}
}
