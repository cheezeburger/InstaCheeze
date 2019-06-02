# InstaCheeze

A standalone Instagram image poster program written in C#.

InstaCheeze lets you post images to your Instagram account on your computer, bypassing posting made available on Instagram mobile app only.

Note as of initial release version: 
1. This program can only post one image at a time. Album and video are not supported at the moment.
2. Login details are not stored on our server nor are being transmitted to us. Any arguments on fraudulent activities on your account occur after the usage of the InstaCheeze are not held responsible by us. 
3. Accounts that require challenge, 2FA or Facebook login will not be able to use this program.
4. Images that are too small will probably face "Value cannot be null" error. Avoid uploading PNG or images that are too small.

### Functions
- Post single image in any image format. JPG/JPEG is highly advised as PNG upload will result in black background. (Will be fixed in future versions)

### To-do List
- Save previous login session
- Album/Video upload
- Fix PNG black background
- 2FA login
- Facebook login
- Challenge require

### Usage
- InstaCheeze executable file can be found in InstaCheeze>bin>Release folder
- Remember me saves login and password when Login button is clicked. To remove the defaults, simply hit the login button without checking Remember Me check box to reset defaults. 

### Screenshots
<h3 align="center">
  <img src="https://i.gyazo.com/9dac561a7f1630649be8d92affe4fd00.png">
  <img src="https://i.gyazo.com/418ae96fc4bb8033f17a8abad412b3bc.png">
</h3>


As this project is mainly for posting images from computers/laptops, others functions i.e: likes, follow, unfollow will not be implemented.
