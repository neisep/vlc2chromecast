# vlc2chromecast
small app to send videos to chromecast with help of videolan

This application will only work as wrapper around VideoLan basicly, cause it will open a process with arguments to broadcast to chromecast

Application has two settings that needs to be filled else it won't work, there is currently no validation for it.

1. Fill in the ip adress to your chromecast
2. Fill in the path to video lan player (vlc.exe)

Then simple drag the video file to application and it will try to automatically start vlc with prefered settings.
