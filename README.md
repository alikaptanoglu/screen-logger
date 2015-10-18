# screen-logger

## What's this?

ScreenLogger is a C# Winform utility that is used to silently capture screenshots of the screen in a specific time interval.

## Why would I need this?

For many reasons:
- You may have somebody in your familly that you'd like to keep an eye on, like a son, brother, etc.
With this, you could know what activities the person is doing on their computer.
- It could easily be modifed to send the shots to a URL. So you could send it to a friend, make it start silently on startup
and send upload the output to a remote server. But this requires some considerations, such as how long you're gonna be monitoring him, what are the things you want to know, like do you want to read facebook conversations, if so, set the quality of the jpg to more than 50.
- You could even use it for your internet pictures browsing. It gets annoying when we're browsing images online and we'd like to save them. Right click on each image, save as, if the path already exists you'd have to save as some random asdfag name etc.
With ScreenLogger, you don't have to do anything, all you have to do is surf the net, browse the pictures, and ScreenLogger will do the capture and saving for you!

## Sounds cool. how do I use it?

Simple enough:
- Select a folder that will hold the captured pics.
- Select an image format, if you select Jpeg, you could manually set the image quality which is from 0 (worse) to 100 (best)
- Select a time interval between the screen shots during logging.
- Click on StartLogging to start the SilentLogging, now the program will disappear and will start taking screen shots for you
in every 't' (t is the time interval you specifed)
- You could also take a manual screenshot by clicking on TakeScreenShot.
- To bring the window again and stop ScreenLogging, you have to go to the parent directory of your ImageFolder
and create a file called "SilentLogging.OFF" .. so if you're saving the images in a folder on the desktop, then 
you have to create the file on the desktop as well.
