# Scheduled Shutdown

## Usage
This is a C# Winforms application that you can run on your Windows PC that allows you to do a schedulled shutdown.
The shutdown time can be manually entered or you can configure it to automatically pull your area's loadshedding
schedule from EskomSePush.

The idea being that if you don't have a UPS, (or one that doesn't notify your PC to shutdown), you can configure the app 
to do a clean shutdown at a scheduled time.

## Remarks
The app is using the Nuget package [SePush.Net](https://github.com/helloserve/sepush.net) that wraps the EskomSePush API
in a .Net library.

To use the EskomSePush feature, you will need to register for a **FREE** [EskomSePush API Token](https://eskomsepush.gumroad.com/l/api) 

There is is no setup project. Just **publish** the app in VS. A single exe is compiled into the bin/package folder.
Create a new folder in your **Program Files (86)** folder and place this exe in there. 

When you first run it there is an option to add this exe rto your **machine startup**. 
