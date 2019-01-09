# Battle-Block-Theater-Level-Editor

Source Code: https://github.com/WiizRDz/Battle-Block-Theater-Level-Editor-Source-Code

Battle Block Theater is a video game developed by The Behemoth for Xbox and PC. The game includes an in-game level editor however it does not grant access to all blocks and backgrounds in the game. 

As a result the Battle Block Theater community finding ways to fully customize levels by editing the hex data of the level files. This process, although functional, was very tedious and required a lot of trial and error along with requiring tech skills. 

The Battle Block Theater Level Editor tool gives users a full GUI that allows them to change all aspects of the level and view their changes in realtime making the process of level editing simple and fast! 

Additionally I have compiled a full resource table as an HTML page that displays all information on block id's and sprites. This table eliminates confusion about block id's (which are not listed anywhere) and defines them all for you.

Screenshot:
![alt text](https://i.gyazo.com/d636934c3f5943862f0dd7fcdfe650b9.png)

### 1. How to get level file from Xbox to PC:

#### a) On the Xbox:
  - Create a level you want to edit
  - Save this level to a USB 'Memory Unit'
  - Turn off Xbox and plug USB into PC

#### b) On the PC:
  - Download the program Horizon if you do not already have it
  - **NOTE:** Horizon can be a pain to download and is often paired with malware and adware. Be careful where you are downloading it from and pay close attention during install. I also recommend running an antivirus scan after program is installed. **Horizon is not a virus**, the program is safe but unfortunately the horizon installer likes to also install malware.
  - Once you have horizon installed and running open the device explorer on the right side of GUI
  - Open the games folder and open the battle block theater folder
  - Double click on the playlist you created
  - Click on contents tab, right click on the level you created and click 'Extract'
  - **Alternatively:**
  - https://www.youtube.com/watch?v=Z9y38iouCK0
  - Watch the video linked until 2:25
  - This will instruct you on how to extract a level file from your Xbox onto your PC

### 2. How to use software
  - Run BattleBlockCustom.exe
  - Click 'Open File' and locate the level file you extracted
  - You can edit the parameters on the top left. Once you have changed any of those parameters click update and the screen on the right will reflect relevant changes
  - On the right there will be a screen allowing you to edit the blocks in your level. Simply type a blockID into the textbox in the top left of the level preview to select that block
  - You can get all blockID's from https://wiizrdz.github.io/Battle-Block-Theater-Level-Editor/ the blockID's are the decimal numbers
  - This website also has tables listing all other resources
  - Left Click to place the selected block where your cursor is hovering
  - Right Click to delete the block you are hovering over
  - You can click 'Update Hex Data' to refresh the raw hex data of your level in the previewer when you make changes to the parameters or blocks in level
  - When you are done editing your level click 'Save File' and save it
  
### 3. Get level back on Xbox from PC:
  - Navigate back to the contents tab in Horizon
  - Right click on the edited level and click 'Replace'
  - Select the edited file
  - Click 'Save, Rehash, and Resign'
  - Plug the USB back into your xbox and the level you created is now playable
  - **Alternatively:**
  - Continue watching the video linked in part 1
  - You do not need to use HxD, just follow the parts where he copies levels onto USB
  - His tutorial also showcases how to rename the levels
