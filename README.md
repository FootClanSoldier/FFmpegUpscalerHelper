# FFmpegUpscalerHelper
<img width="503" alt="app" src="https://user-images.githubusercontent.com/104313051/164985734-851253cb-c93c-47d4-a642-cc3597fb0636.png">

## About
Simple program with UI for exporting video to png and encoding png images to video using FFmpeg, for the purpose of upscaling. This program does not upscale your video, it's a tool to be used to save time for your upscaling process. 

Instead of opening CMD yourself and navigating to your ffmpeg location and then enter the command this program does all that for you. Saves a lot of time when working with multiple videos. It does however require some knowledge of FFmpeg commands for you to be able to customize your command for your needs. 

Encoding presets can be fully modified and comes with some decent default settings for x264 encodes. I plan to add more features in the future, this was just something I rushed together quickly in 2 days and has been extremly useful for me ever since.


<img width="503" alt="Untitled" src="https://user-images.githubusercontent.com/104313051/164991558-3401484d-4e83-49d3-baef-a2c9b038bca0.png">

## Getting started
**Dependencies**
- .NET Framework 4.7.2
- FFmpeg.exe

**Required Setting** 
- First thing you need to do to get this program to work is going into Settings and selecting the path to your ffmpeg.exe file, and then click the save settings button. 
<img width="503" alt="Untitled2" src="https://user-images.githubusercontent.com/104313051/165087676-4e7d7037-8bdb-408b-9065-d71ab0b0f372.png">

**Other Settings** 
- You can edit the default png dimension to be used when exporting video to png
- You can enable or disable if the target folder your exporting/encoding to should be opened when the command has been started
