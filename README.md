# FFmpegUpscalerHelper
Simple program with UI for exporting video to png and encoding png images to video using FFmpeg, for the purpose of upscaling.

<img width="503" alt="app" src="https://user-images.githubusercontent.com/104313051/164985734-851253cb-c93c-47d4-a642-cc3597fb0636.png">

Comes with 2 default preset commands that can be fully modifiable. 
Commands need to include [InputImgLocation] and [OutputLocation]

As shown from one of the default commands here:
>-r 24000/1001 -f image2 -start_number 1 -i [InputImgLocation]\\%06d.png -c:v libx264 -preset veryslow -crf 18 -pix_fmt yuv420p -profile:v high -level:v 4.1 -refs 4 -bf 3 -vf colormatrix=bt601:bt709 -color_primaries bt709 -color_trc bt709 -colorspace bt709 [OutputLocation]

I plan to add more features in the future, this was just something I rushed togheter quickly in 2 days and have been extremly useful for me ever since.
