namespace BattleBlockCustom
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
			this.openFile = new System.Windows.Forms.Button();
			this.saveFile = new System.Windows.Forms.Button();
			this.fileData = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.parameters = new System.Windows.Forms.GroupBox();
			this.levelTimeTextbox = new System.Windows.Forms.TextBox();
			this.levelTimeLabel = new System.Windows.Forms.Label();
			this.plantColourTextbox = new System.Windows.Forms.TextBox();
			this.plantColourLabel = new System.Windows.Forms.Label();
			this.waterColourTextbox = new System.Windows.Forms.TextBox();
			this.waterColourLabel = new System.Windows.Forms.Label();
			this.block2ColourTextbox = new System.Windows.Forms.TextBox();
			this.block2ColourLabel = new System.Windows.Forms.Label();
			this.block1ColourTextbox = new System.Windows.Forms.TextBox();
			this.block1ColourLabel = new System.Windows.Forms.Label();
			this.specialBGTextbox = new System.Windows.Forms.TextBox();
			this.specialBGLabel = new System.Windows.Forms.Label();
			this.specialFGTextbox = new System.Windows.Forms.TextBox();
			this.specialFGLabel = new System.Windows.Forms.Label();
			this.bgStyleTextbox = new System.Windows.Forms.TextBox();
			this.bgStyleLabel = new System.Windows.Forms.Label();
			this.skyColourTextbox = new System.Windows.Forms.TextBox();
			this.skyColourLabel = new System.Windows.Forms.Label();
			this.blockStyleTextbox = new System.Windows.Forms.TextBox();
			this.blockStyleLabel = new System.Windows.Forms.Label();
			this.gameModeTextbox = new System.Windows.Forms.TextBox();
			this.updateParamButton = new System.Windows.Forms.Button();
			this.gameModeLabel = new System.Windows.Forms.Label();
			this.levelHeightTextbox = new System.Windows.Forms.TextBox();
			this.levelHeightLabel = new System.Windows.Forms.Label();
			this.levelWidthTextbox = new System.Windows.Forms.TextBox();
			this.levelWidthLabel = new System.Windows.Forms.Label();
			this.rawHexLabel = new System.Windows.Forms.Label();
			this.levelPanel = new System.Windows.Forms.Panel();
			this.placeBlockValTextbox = new System.Windows.Forms.TextBox();
			this.updateHexDataButton = new System.Windows.Forms.Button();
			this.easyHexCheckbox = new System.Windows.Forms.CheckBox();
			this.helpButton = new System.Windows.Forms.Button();
			this.enableBGCheckbox = new System.Windows.Forms.CheckBox();
			this.parameters.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFile
			// 
			this.openFile.Location = new System.Drawing.Point(13, 13);
			this.openFile.Name = "openFile";
			this.openFile.Size = new System.Drawing.Size(75, 23);
			this.openFile.TabIndex = 0;
			this.openFile.Text = "Open File";
			this.openFile.UseVisualStyleBackColor = true;
			this.openFile.Click += new System.EventHandler(this.openFile_Click);
			// 
			// saveFile
			// 
			this.saveFile.Location = new System.Drawing.Point(95, 13);
			this.saveFile.Name = "saveFile";
			this.saveFile.Size = new System.Drawing.Size(75, 23);
			this.saveFile.TabIndex = 1;
			this.saveFile.Text = "Save File";
			this.saveFile.UseVisualStyleBackColor = true;
			this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
			// 
			// fileData
			// 
			this.fileData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.fileData.BackColor = System.Drawing.Color.White;
			this.fileData.Font = new System.Drawing.Font("Consolas", 14F);
			this.fileData.Location = new System.Drawing.Point(12, 266);
			this.fileData.Multiline = true;
			this.fileData.Name = "fileData";
			this.fileData.ReadOnly = true;
			this.fileData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.fileData.Size = new System.Drawing.Size(576, 255);
			this.fileData.TabIndex = 2;
			this.fileData.WordWrap = false;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// parameters
			// 
			this.parameters.Controls.Add(this.levelTimeTextbox);
			this.parameters.Controls.Add(this.levelTimeLabel);
			this.parameters.Controls.Add(this.plantColourTextbox);
			this.parameters.Controls.Add(this.plantColourLabel);
			this.parameters.Controls.Add(this.waterColourTextbox);
			this.parameters.Controls.Add(this.waterColourLabel);
			this.parameters.Controls.Add(this.block2ColourTextbox);
			this.parameters.Controls.Add(this.block2ColourLabel);
			this.parameters.Controls.Add(this.block1ColourTextbox);
			this.parameters.Controls.Add(this.block1ColourLabel);
			this.parameters.Controls.Add(this.specialBGTextbox);
			this.parameters.Controls.Add(this.specialBGLabel);
			this.parameters.Controls.Add(this.specialFGTextbox);
			this.parameters.Controls.Add(this.specialFGLabel);
			this.parameters.Controls.Add(this.bgStyleTextbox);
			this.parameters.Controls.Add(this.bgStyleLabel);
			this.parameters.Controls.Add(this.skyColourTextbox);
			this.parameters.Controls.Add(this.skyColourLabel);
			this.parameters.Controls.Add(this.blockStyleTextbox);
			this.parameters.Controls.Add(this.blockStyleLabel);
			this.parameters.Controls.Add(this.gameModeTextbox);
			this.parameters.Controls.Add(this.updateParamButton);
			this.parameters.Controls.Add(this.gameModeLabel);
			this.parameters.Controls.Add(this.levelHeightTextbox);
			this.parameters.Controls.Add(this.levelHeightLabel);
			this.parameters.Controls.Add(this.levelWidthTextbox);
			this.parameters.Controls.Add(this.levelWidthLabel);
			this.parameters.Location = new System.Drawing.Point(13, 42);
			this.parameters.Name = "parameters";
			this.parameters.Size = new System.Drawing.Size(576, 177);
			this.parameters.TabIndex = 4;
			this.parameters.TabStop = false;
			this.parameters.Text = "Parameters";
			// 
			// levelTimeTextbox
			// 
			this.levelTimeTextbox.Location = new System.Drawing.Point(342, 141);
			this.levelTimeTextbox.Name = "levelTimeTextbox";
			this.levelTimeTextbox.Size = new System.Drawing.Size(61, 20);
			this.levelTimeTextbox.TabIndex = 29;
			// 
			// levelTimeLabel
			// 
			this.levelTimeLabel.AutoSize = true;
			this.levelTimeLabel.Location = new System.Drawing.Point(339, 125);
			this.levelTimeLabel.Name = "levelTimeLabel";
			this.levelTimeLabel.Size = new System.Drawing.Size(59, 13);
			this.levelTimeLabel.TabIndex = 28;
			this.levelTimeLabel.Text = "Level Time";
			// 
			// plantColourTextbox
			// 
			this.plantColourTextbox.Location = new System.Drawing.Point(260, 141);
			this.plantColourTextbox.Name = "plantColourTextbox";
			this.plantColourTextbox.Size = new System.Drawing.Size(61, 20);
			this.plantColourTextbox.TabIndex = 27;
			// 
			// plantColourLabel
			// 
			this.plantColourLabel.AutoSize = true;
			this.plantColourLabel.Location = new System.Drawing.Point(257, 125);
			this.plantColourLabel.Name = "plantColourLabel";
			this.plantColourLabel.Size = new System.Drawing.Size(64, 13);
			this.plantColourLabel.TabIndex = 26;
			this.plantColourLabel.Text = "Plant Colour";
			// 
			// waterColourTextbox
			// 
			this.waterColourTextbox.Location = new System.Drawing.Point(178, 142);
			this.waterColourTextbox.Name = "waterColourTextbox";
			this.waterColourTextbox.Size = new System.Drawing.Size(62, 20);
			this.waterColourTextbox.TabIndex = 25;
			// 
			// waterColourLabel
			// 
			this.waterColourLabel.AutoSize = true;
			this.waterColourLabel.Location = new System.Drawing.Point(175, 125);
			this.waterColourLabel.Name = "waterColourLabel";
			this.waterColourLabel.Size = new System.Drawing.Size(69, 13);
			this.waterColourLabel.TabIndex = 24;
			this.waterColourLabel.Text = "Water Colour";
			// 
			// block2ColourTextbox
			// 
			this.block2ColourTextbox.Location = new System.Drawing.Point(96, 141);
			this.block2ColourTextbox.Name = "block2ColourTextbox";
			this.block2ColourTextbox.Size = new System.Drawing.Size(61, 20);
			this.block2ColourTextbox.TabIndex = 23;
			// 
			// block2ColourLabel
			// 
			this.block2ColourLabel.AutoSize = true;
			this.block2ColourLabel.Location = new System.Drawing.Point(93, 125);
			this.block2ColourLabel.Name = "block2ColourLabel";
			this.block2ColourLabel.Size = new System.Drawing.Size(76, 13);
			this.block2ColourLabel.TabIndex = 22;
			this.block2ColourLabel.Text = "Block 2 Colour";
			// 
			// block1ColourTextbox
			// 
			this.block1ColourTextbox.Location = new System.Drawing.Point(14, 141);
			this.block1ColourTextbox.Name = "block1ColourTextbox";
			this.block1ColourTextbox.Size = new System.Drawing.Size(61, 20);
			this.block1ColourTextbox.TabIndex = 21;
			// 
			// block1ColourLabel
			// 
			this.block1ColourLabel.AutoSize = true;
			this.block1ColourLabel.Location = new System.Drawing.Point(11, 125);
			this.block1ColourLabel.Name = "block1ColourLabel";
			this.block1ColourLabel.Size = new System.Drawing.Size(76, 13);
			this.block1ColourLabel.TabIndex = 20;
			this.block1ColourLabel.Text = "Block 1 Colour";
			// 
			// specialBGTextbox
			// 
			this.specialBGTextbox.Location = new System.Drawing.Point(342, 93);
			this.specialBGTextbox.Name = "specialBGTextbox";
			this.specialBGTextbox.Size = new System.Drawing.Size(61, 20);
			this.specialBGTextbox.TabIndex = 19;
			// 
			// specialBGLabel
			// 
			this.specialBGLabel.AutoSize = true;
			this.specialBGLabel.Location = new System.Drawing.Point(339, 77);
			this.specialBGLabel.Name = "specialBGLabel";
			this.specialBGLabel.Size = new System.Drawing.Size(60, 13);
			this.specialBGLabel.TabIndex = 18;
			this.specialBGLabel.Text = "Special BG";
			// 
			// specialFGTextbox
			// 
			this.specialFGTextbox.Location = new System.Drawing.Point(260, 93);
			this.specialFGTextbox.Name = "specialFGTextbox";
			this.specialFGTextbox.Size = new System.Drawing.Size(61, 20);
			this.specialFGTextbox.TabIndex = 17;
			// 
			// specialFGLabel
			// 
			this.specialFGLabel.AutoSize = true;
			this.specialFGLabel.Location = new System.Drawing.Point(257, 77);
			this.specialFGLabel.Name = "specialFGLabel";
			this.specialFGLabel.Size = new System.Drawing.Size(59, 13);
			this.specialFGLabel.TabIndex = 16;
			this.specialFGLabel.Text = "Special FG";
			// 
			// bgStyleTextbox
			// 
			this.bgStyleTextbox.Location = new System.Drawing.Point(178, 94);
			this.bgStyleTextbox.Name = "bgStyleTextbox";
			this.bgStyleTextbox.Size = new System.Drawing.Size(62, 20);
			this.bgStyleTextbox.TabIndex = 15;
			// 
			// bgStyleLabel
			// 
			this.bgStyleLabel.AutoSize = true;
			this.bgStyleLabel.Location = new System.Drawing.Point(175, 77);
			this.bgStyleLabel.Name = "bgStyleLabel";
			this.bgStyleLabel.Size = new System.Drawing.Size(48, 13);
			this.bgStyleLabel.TabIndex = 14;
			this.bgStyleLabel.Text = "BG Style";
			// 
			// skyColourTextbox
			// 
			this.skyColourTextbox.Location = new System.Drawing.Point(96, 93);
			this.skyColourTextbox.Name = "skyColourTextbox";
			this.skyColourTextbox.Size = new System.Drawing.Size(61, 20);
			this.skyColourTextbox.TabIndex = 13;
			// 
			// skyColourLabel
			// 
			this.skyColourLabel.AutoSize = true;
			this.skyColourLabel.Location = new System.Drawing.Point(93, 77);
			this.skyColourLabel.Name = "skyColourLabel";
			this.skyColourLabel.Size = new System.Drawing.Size(58, 13);
			this.skyColourLabel.TabIndex = 12;
			this.skyColourLabel.Text = "Sky Colour";
			// 
			// blockStyleTextbox
			// 
			this.blockStyleTextbox.Location = new System.Drawing.Point(14, 93);
			this.blockStyleTextbox.Name = "blockStyleTextbox";
			this.blockStyleTextbox.Size = new System.Drawing.Size(61, 20);
			this.blockStyleTextbox.TabIndex = 11;
			// 
			// blockStyleLabel
			// 
			this.blockStyleLabel.AutoSize = true;
			this.blockStyleLabel.Location = new System.Drawing.Point(11, 77);
			this.blockStyleLabel.Name = "blockStyleLabel";
			this.blockStyleLabel.Size = new System.Drawing.Size(60, 13);
			this.blockStyleLabel.TabIndex = 10;
			this.blockStyleLabel.Text = "Block Style";
			// 
			// gameModeTextbox
			// 
			this.gameModeTextbox.Location = new System.Drawing.Point(178, 46);
			this.gameModeTextbox.Name = "gameModeTextbox";
			this.gameModeTextbox.Size = new System.Drawing.Size(62, 20);
			this.gameModeTextbox.TabIndex = 9;
			// 
			// updateParamButton
			// 
			this.updateParamButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.updateParamButton.Location = new System.Drawing.Point(426, 12);
			this.updateParamButton.Name = "updateParamButton";
			this.updateParamButton.Size = new System.Drawing.Size(144, 159);
			this.updateParamButton.TabIndex = 8;
			this.updateParamButton.Text = "Update";
			this.updateParamButton.UseVisualStyleBackColor = false;
			this.updateParamButton.Click += new System.EventHandler(this.updateParamButton_Click);
			// 
			// gameModeLabel
			// 
			this.gameModeLabel.AutoSize = true;
			this.gameModeLabel.Location = new System.Drawing.Point(175, 29);
			this.gameModeLabel.Name = "gameModeLabel";
			this.gameModeLabel.Size = new System.Drawing.Size(65, 13);
			this.gameModeLabel.TabIndex = 4;
			this.gameModeLabel.Text = "Game Mode";
			// 
			// levelHeightTextbox
			// 
			this.levelHeightTextbox.Location = new System.Drawing.Point(96, 45);
			this.levelHeightTextbox.Name = "levelHeightTextbox";
			this.levelHeightTextbox.Size = new System.Drawing.Size(61, 20);
			this.levelHeightTextbox.TabIndex = 3;
			// 
			// levelHeightLabel
			// 
			this.levelHeightLabel.AutoSize = true;
			this.levelHeightLabel.Location = new System.Drawing.Point(93, 29);
			this.levelHeightLabel.Name = "levelHeightLabel";
			this.levelHeightLabel.Size = new System.Drawing.Size(67, 13);
			this.levelHeightLabel.TabIndex = 2;
			this.levelHeightLabel.Text = "Level Height";
			// 
			// levelWidthTextbox
			// 
			this.levelWidthTextbox.Location = new System.Drawing.Point(14, 45);
			this.levelWidthTextbox.Name = "levelWidthTextbox";
			this.levelWidthTextbox.Size = new System.Drawing.Size(61, 20);
			this.levelWidthTextbox.TabIndex = 1;
			// 
			// levelWidthLabel
			// 
			this.levelWidthLabel.AutoSize = true;
			this.levelWidthLabel.Location = new System.Drawing.Point(11, 29);
			this.levelWidthLabel.Name = "levelWidthLabel";
			this.levelWidthLabel.Size = new System.Drawing.Size(64, 13);
			this.levelWidthLabel.TabIndex = 0;
			this.levelWidthLabel.Text = "Level Width";
			// 
			// rawHexLabel
			// 
			this.rawHexLabel.AutoSize = true;
			this.rawHexLabel.Location = new System.Drawing.Point(13, 247);
			this.rawHexLabel.Name = "rawHexLabel";
			this.rawHexLabel.Size = new System.Drawing.Size(77, 13);
			this.rawHexLabel.TabIndex = 5;
			this.rawHexLabel.Text = "Raw Hex Data";
			// 
			// levelPanel
			// 
			this.levelPanel.BackColor = System.Drawing.Color.White;
			this.levelPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.levelPanel.Location = new System.Drawing.Point(595, 71);
			this.levelPanel.Name = "levelPanel";
			this.levelPanel.Size = new System.Drawing.Size(600, 450);
			this.levelPanel.TabIndex = 6;
			// 
			// placeBlockValTextbox
			// 
			this.placeBlockValTextbox.Location = new System.Drawing.Point(595, 42);
			this.placeBlockValTextbox.Name = "placeBlockValTextbox";
			this.placeBlockValTextbox.Size = new System.Drawing.Size(100, 20);
			this.placeBlockValTextbox.TabIndex = 0;
			this.placeBlockValTextbox.Text = "0";
			this.placeBlockValTextbox.TextChanged += new System.EventHandler(this.placeBlockValTextbox_TextChanged);
			// 
			// updateHexDataButton
			// 
			this.updateHexDataButton.Location = new System.Drawing.Point(487, 240);
			this.updateHexDataButton.Name = "updateHexDataButton";
			this.updateHexDataButton.Size = new System.Drawing.Size(102, 23);
			this.updateHexDataButton.TabIndex = 7;
			this.updateHexDataButton.Text = "Update Hex Data";
			this.updateHexDataButton.UseVisualStyleBackColor = true;
			this.updateHexDataButton.Click += new System.EventHandler(this.updateHexDataButton_Click);
			// 
			// easyHexCheckbox
			// 
			this.easyHexCheckbox.AutoSize = true;
			this.easyHexCheckbox.Checked = true;
			this.easyHexCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.easyHexCheckbox.Location = new System.Drawing.Point(415, 245);
			this.easyHexCheckbox.Name = "easyHexCheckbox";
			this.easyHexCheckbox.Size = new System.Drawing.Size(71, 17);
			this.easyHexCheckbox.TabIndex = 8;
			this.easyHexCheckbox.Text = "Easy Hex";
			this.easyHexCheckbox.UseVisualStyleBackColor = true;
			// 
			// helpButton
			// 
			this.helpButton.Location = new System.Drawing.Point(177, 13);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new System.Drawing.Size(75, 23);
			this.helpButton.TabIndex = 9;
			this.helpButton.Text = "Help";
			this.helpButton.UseVisualStyleBackColor = true;
			this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
			// 
			// enableBGCheckbox
			// 
			this.enableBGCheckbox.AutoSize = true;
			this.enableBGCheckbox.Checked = true;
			this.enableBGCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enableBGCheckbox.Location = new System.Drawing.Point(1075, 45);
			this.enableBGCheckbox.Name = "enableBGCheckbox";
			this.enableBGCheckbox.Size = new System.Drawing.Size(120, 17);
			this.enableBGCheckbox.TabIndex = 10;
			this.enableBGCheckbox.Text = "Enable Background";
			this.enableBGCheckbox.UseVisualStyleBackColor = true;
			this.enableBGCheckbox.CheckedChanged += new System.EventHandler(this.enableBGCheckbox_CheckedChanged);
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1207, 533);
			this.Controls.Add(this.enableBGCheckbox);
			this.Controls.Add(this.helpButton);
			this.Controls.Add(this.easyHexCheckbox);
			this.Controls.Add(this.updateHexDataButton);
			this.Controls.Add(this.placeBlockValTextbox);
			this.Controls.Add(this.levelPanel);
			this.Controls.Add(this.rawHexLabel);
			this.Controls.Add(this.fileData);
			this.Controls.Add(this.saveFile);
			this.Controls.Add(this.openFile);
			this.Controls.Add(this.parameters);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Window";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Battle Block Level Editor";
			this.parameters.ResumeLayout(false);
			this.parameters.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button openFile;
		private System.Windows.Forms.Button saveFile;
		private System.Windows.Forms.TextBox fileData;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.GroupBox parameters;
		private System.Windows.Forms.Label levelWidthLabel;
		private System.Windows.Forms.TextBox levelWidthTextbox;
		private System.Windows.Forms.Button updateParamButton;
		private System.Windows.Forms.Label gameModeLabel;
		private System.Windows.Forms.TextBox levelHeightTextbox;
		private System.Windows.Forms.Label levelHeightLabel;
		private System.Windows.Forms.TextBox gameModeTextbox;
		private System.Windows.Forms.TextBox bgStyleTextbox;
		private System.Windows.Forms.Label bgStyleLabel;
		private System.Windows.Forms.TextBox skyColourTextbox;
		private System.Windows.Forms.Label skyColourLabel;
		private System.Windows.Forms.TextBox blockStyleTextbox;
		private System.Windows.Forms.Label blockStyleLabel;
		private System.Windows.Forms.TextBox levelTimeTextbox;
		private System.Windows.Forms.Label levelTimeLabel;
		private System.Windows.Forms.TextBox plantColourTextbox;
		private System.Windows.Forms.Label plantColourLabel;
		private System.Windows.Forms.TextBox waterColourTextbox;
		private System.Windows.Forms.Label waterColourLabel;
		private System.Windows.Forms.TextBox block2ColourTextbox;
		private System.Windows.Forms.Label block2ColourLabel;
		private System.Windows.Forms.TextBox block1ColourTextbox;
		private System.Windows.Forms.Label block1ColourLabel;
		private System.Windows.Forms.TextBox specialBGTextbox;
		private System.Windows.Forms.Label specialBGLabel;
		private System.Windows.Forms.TextBox specialFGTextbox;
		private System.Windows.Forms.Label specialFGLabel;
		private System.Windows.Forms.Label rawHexLabel;
		private System.Windows.Forms.Panel levelPanel;
		private System.Windows.Forms.TextBox placeBlockValTextbox;
		private System.Windows.Forms.Button updateHexDataButton;
		private System.Windows.Forms.CheckBox easyHexCheckbox;
		private System.Windows.Forms.Button helpButton;
		private System.Windows.Forms.CheckBox enableBGCheckbox;
	}
}

