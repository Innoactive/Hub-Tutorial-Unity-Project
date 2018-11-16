# Innoactive Hub SDK Unity Tutorial

This repository provides a step-by-step guide to start developing with the _Innoactive Hub Unity SDK_. 

You will learn how to setup your Unity project with the _Innoactive Hub_ and create Unity scenes, populate them with interactable objects and your own tools and how to persist them. Furthermore, we cover multiplayer capabilities, our extendable XML menu as well as the context menu and many more features.

The tutorial is split into chapters, where every chapter builds upon the previous ones. We do not want you to just read code but learn how to use the _Hub_ by implementing yourself. Therefore, we provide stub code in (almost) every chapter and an explanation on what to do. Just follow the instructions of each chatper. Most chapters also have a branch which includes our suggested solution.

The tutorial is currently based on version **3.3.2**, but will be kept up to date in the future - and also works for previous versions.

# Overview

The _Innoactive Hub Unity SDK_ is based on [VRTK](https://github.com/thestonefox/VRTK) to provide an easy entry point into Virtual Reality interactions as well as development for multiple Head Mounted Displays (HMD). 

Additionally, Photon as a proven network technology is used to guarantee stable multi user experience.

# What you need to start

Simply clone this repository and get your own _Innoactive Hub Unity SDK_ and access to the _Innoactive Hub Backend_ (optional but recommended).

# Table of contents

&nbsp; [**Chapter 1** Setup Unity project](#Chapter1)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **1.1** Importing dependencies

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **1.2** _Innoactive Hub SDK Wizard_

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **1.3** Photon Settings


&nbsp; [**Chapter 2** Setup Unity scene](#Chapter2)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **2.1** Prepare scene

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **2.2** Setup Hub scene

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **2.3** Scene components

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **2.4** Basic environment


&nbsp; **Chapter 3** Explore the basics

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **3.1** Teleporter

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **3.2** Prepare scene

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **3.3** Open menu

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **3.4** Spawn and grab objects

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **3.5** Use tools and make use of their context menu

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **3.6** Additional goodies

[//]: # (Additional goodies includes bi manual scaling and changing avatar representation as well as exploring other tools)


&nbsp; **Chapter 4** Get around your scene

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **4.1** Restrict teleporter

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **4.2** Restrict areas


&nbsp; **Chapter 5** Create interactable objects

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **5.1** Basic interactable objects

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **5.2** Snap and drop zones


&nbsp; **Chapter 6** Flashlight: Create custom tool

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **6.1** Create interactable flashlight

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **6.2** Add logic to your tool


&nbsp; **Chapter 7** Extend context menu

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **7.1** Default context actions

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **7.2** Custom context actions


&nbsp; **Chapter 8** Extend main menu 

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **8.1** Create your own menu

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **8.2** Add tool to menu

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **8.3** Custom menu actions

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **8.4** Complex menu actions

[//]: # (Maybe show how to make an application quit button or something more stupid but similar)


&nbsp; **Chapter 9** _Innoactive Hub_ Backend Setup

&nbsp; &nbsp; _**Note:** You can only complete this chapter if you have access to the Innoactive Hub Backend_

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **9.1** Client config, login check and login scene

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **9.2** Realities, Spaces and Environments

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **9.3** Load backend content

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **9.4** Access and populate your Web Management Console


&nbsp; **Chapter 10** Persistence

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **10.1** Save and load space

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **10.2** Persist tools and objects

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **10.3** Scene navigation


&nbsp; **Chapter 11** Multi-User

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **11.1** Multi-user sessions and Photon config

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **11.2** Make basic objects networked

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **11.3** Make tools networked


&nbsp; **Chapter 12** Windows System

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **12.1** Window Factory

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **12.2** Add Buttons

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **12.3** Add to menu


&nbsp; **Chapter 13** Customize controllers

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **13.1** Create new controllers

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **13.2** Controller config and controller config chooser


&nbsp; **Chapter 14** Spectator

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **14.1** Setup a spectator


## <a name="Chapter1"></a>**Chapter 1** Setup Unity project

After opening the Unity project you will find some folders like Materials, Models, Prefabs etc. in your project structure. You can ignore these for now.

### Importing Innoactive Hub SDK

To start setting up your project, download your version of the _Innoactive Hub Unity SDK_ from http://docs.hub.innoactive.de/. Import the unitypackage by dragging it into your Unity project and wait till it is imported. _Reminder:_ In this tutorial we use version 3.3.2.

The Hub SDK will be imported into _Assets/Extensions_ which is also what we recommend. An error will pop-up which can be ignored for now.

### Importing Steam VR

Download and import _Steam VR_ version 1.2.3 from https://github.com/ValveSoftware/steamvr_unity_plugin/releases/tag/1.2.3. We recommend moving the Steam VR folder into _Assets/Extensions_, right next to the Hub SDK.

**Important**: Steam VR version 2 which is available on the Asset Store is not supported by VRTK 3.3.0 as currently used in the _Innoactive Hub SDK_.

After the Hub SDK as well as Steam VR is imported we take care of the following error (if it is shown):

```Assets/Extensions/hub-sdk/SDK/Utils/UnityDotNetCheck/UnityDotNetCheck.cs(6,0): error CS1029: #error: 'This Unity project is configured for .Net 2.0 subset, but the Innoactive Hub SDK requires full .Net functionality. Please go to "PlayerSettings > Other Settings" and change Api Compatibility Level to .Net 2.0'```

Simply do what it says and go to the Unity PlayerSettings and change the Api Compatibility Level in Other Settings from _.Net 2.0 Subset_ to _.Net 2.0_.

### Hub SDK Wizard

To make your life easier we included the _Hub SDK Setup Wizard_ which helps you to setup your project. You can find it by clicking on ```Innoactive > Hub > Setup Wizard```. The Wizard will pop-up and show you a list of settings with errors and warnings. We can ignore most of them for now (especially because they are automatically created for you) but want to explain some important ones.

The _Hub Settings_ are your central point for general settings within your application. You can set specific build settings, colors to customize your experience, standard menu actions etc. Most of this will be covered in later chapters.

The _Hub Client Credentials_ are your personal credentials to access the backend which you get from your Innoactive contact person. It is recommended to use the wizard to populate these values but also possible to alter/include the client-config.json file in _Hub-Tutorial-Unity-Project/Config_.

As mentioned before Multi User is based on _Photon_. To configure your multi user settings we use another config file for this which you can also find in _Hub-Tutorial-Unity-Project/Config_ (after you clicked on save in the SDK Wizard). For now multi user is turned off but will be explained in Chapter 11.

So for now just enter your _Hub Client Credentials_ and click on save on the bottom of the _Hub SDK Wizard_. The rest is handled for you. Just to be save you should check your _Photon Settings_ in _Hub-Tutorial-Unity-Project/Config/photon-config.json_ and make sure _hosting_ is set to _"OfflineMode"_.

## <a name="Chapter2"></a>**Chapter 2** Setup Unity scene

Open the scene _TutorialScene_ in your projects _Scene_ folder. This is simply a newly created standard Unity scene.

Since we are developing a Virtual Reality application based on _VRTK_ start by removing the _Main Camera_ in the scene and save. We will not need the standard camera.

Next we setup the scene so we can use all features of the _Innoactive Hub_. We took over this process for you to make sure you have everything you need and are good to go. Clicking ```Innoactive > Hub > Setup > Setup Current Scene as Hub Scene``` populates your scene with a bunch of GameObjects which we briefly explain.

### Components
**[HUB-BOOTSTRAP]** is responsible for scene initialization - handles setup of persistence and multi-user, and loading of the correct space (especially for multi-user sessions).

**[HUB-MULTIUSER]** is responsible for managing multi-user sessions.

**[HUB-PERSISTENCE]** handles storing and restoring scene states (i.e. saving/loading).

**[HUB-LOGIN_CHECK]** ensures that a connection to the _Innoactive Hub_ backend is possible. If not, it will redirect to a login scene.

**[HUB-DEBUG_UI]** provides a Debug Info overlay when pressing Ctrl+G.

**[HUB-VR-SUPERVISOR-CLIENT]** allows connecting to the _Innoactive Hub Launcher_, allowing to switch to different VR applications.

**[HUB-MAINTHREAD_DISPATCHER]** provides required components for threading.

**[HUB-PLAYER-SETUP-MANAGER]** is responsible for setting up the cameras. This includes but is not limited to disabling the HMD if so selected in the player-config.json as well as enabling / disabling the high-resolution spectator view (also configured via the player-config.json) which shows an interpolated first person view in the native resolution of the attached monitor.

**[HUB-MENU-SETUP]** allows configuration of the menu to use, and also allows configuring the user menu.

**[VRTK_Setup]** manages the run-time setup and configuration of VR cameras and interactions.

<br>

Disable **[HUB-LOGIN_CHECK]** and **[HUB-VR-SUPERVISOR-CLIENT]** for now. We will come back to those later.

**Note**: Setting up the scene before importing _Steam VR_ might mess up [VRTK_Setup]!

### Environment

To make your scene a less empty space add a simple floor. You can find one in the _Prefabs_ folder and drag it into the scene.

_Find solution in branch: Chapter_2/Setup_Unity_Scene_