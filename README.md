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


&nbsp; [**Chapter 3** Explore the basics](#Chapter3)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **3.1** Teleporter

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **3.2** Prepare scene

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **3.3** Open menu

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **3.4** Spawn and grab objects

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **3.5** Use tools and make use of their context menu

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **3.6** Additional goodies

[//]: # (Additional goodies includes bi manual scaling and changing avatar representation as well as exploring other tools)


&nbsp; [**Chapter 4** Get around your scene](#Chapter4)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **4.1** Restrict teleporter

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **4.2** Restrict areas


&nbsp; [**Chapter 5** Create interactable objects](#Chapter5)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **5.1** Basic interactable objects

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **5.2** Snap and drop zones


&nbsp; [**Chapter 6** Flashlight: Create custom tool](#Chapter6)

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

**[HUB-VR-LAUNCHER-CLIENT]** allows connecting to the _Innoactive Hub Launcher_, allowing to switch to different VR applications.

**[HUB-MAINTHREAD_DISPATCHER]** provides required components for threading.

**[HUB-PLAYER-SETUP-MANAGER]** is responsible for setting up the cameras. This includes but is not limited to disabling the HMD if so selected in the player-config.json as well as enabling / disabling the high-resolution spectator view (also configured via the player-config.json) which shows an interpolated first person view in the native resolution of the attached monitor.

**[HUB-MENU-SETUP]** allows configuration of the menu to use, and also allows configuring the user menu.

**[VRTK_Setup]** manages the run-time setup and configuration of VR cameras and interactions.

<br>

Disable **[HUB-LOGIN_CHECK]** and **[HUB-VR-LAUNCHER-CLIENT]** for now. We will come back to those later.

**Note:** Setting up the scene before importing _Steam VR_ might mess up [VRTK_Setup]!

### Environment

To make your scene a less empty space add a simple floor. You can find one in the _Prefabs_ folder and drag it into the scene.

**Solution:** Find the initially setup scene in _ChapterSolutions/Chapter-2_Setup-Unity-Scene.unitypackage_.

## <a name="Chapter3"></a>**Chapter 3** Explore the basics

This chapter is all about exploring the basic features of the _Innoactive Hub_ and will show you what is possible even without writing a single line of code. Start the application by clicking the Play button in Unity. 

First we cover the teleporter, since we all know getting around a virtual space does not work with just walking. We assume you are using a _HTC Vive_ - button configuration may vary between HMDs. Press the Trigger (with your index finger) to show the teleporter and release to teleport to the circled area. Teleport around the floor a bit to get used to it.

Next let's focus on one of the core features. Touching the Touchpad will open the _Main Menu_. You will see different categories and can navigate through the menu by swiping right, left, up and down on the touchpad. Navigate to Tools and spawn a Pencil tool by selecting it and pressing the Touchpad.

The menu grants you access to all kinds of Assets, like Tools, 3D Objects, Images, Videos, PDFs, other Scenes and many more. You can change and extend the menu as you like which will be covered in a later chapter.

After you spawned the pen you can grab it by touching it (it will get highlighted) and then pressing the grab button on the side of your Vive Controller. We included an optional smart grab functionality which is turned on by default. You can either grab an object by keeping the grab button pressed or by quickly clicking the grab button. Try it out and see the difference. By clicking the grab button again you will release the object.

Using an object is as simple as grabbing one. So first grab the pen again, if you released it before, and now use the Trigger to draw some lines in your virtual space. You will draw as long as you keep the Trigger pressed. 

Next to the Main Menu, which is a global menu, exists the object-based _Context Menu_. You can open an object's Context Menu by either touching or grabbing it and then touching the Touchpad of your controller. Besides default features like deleting and turning gravity on you can add object specific behavior. For example you can change the pen's color, so newly drawn strokes will have a different color. Try it by deleting a previously drawn line and then drawing a new one in another color.

Just play around with the menu and spawned objects and see what you can do with the different things. For instance spawn a basic object from the objects menu, change it's color and physics and use bi-manual scaling to make it bigger and smaller (grab it with both hands and move the hands apart). Furthermore, you can change your own representation in VR by changing your avatar in the Avatar menu section. It's also possible to create your own avatar which is a more advanced topic and will not be covered in this tutorial.

## <a name="Chapter4"></a>**Chapter 4** Get around your scene

As briefly mentioned in the previous chapter using the teleporter is your way to get around the scene. But often it is necessary to restrict the user from going everywhere in the scene.

Start by dragging the _Table_ and the _BrickWall_ prefabs into your scene. We obviously do not want the user to stand ontop of the table or the wall, so we want to restrict these areas. Add the script _DoNotAllowTeleportingHere_ to both GameObjects to mark them. In VRTK's _Policy List_ (```[VRTK_Setup] > [VRTK_Scripts] > PlayArea > Script VRTK_PolicyList```) you can see that the Check List as well as the checked elements are already set up to disallow teleporting on every object with the just added script. You can of course change that list and add new elements.

Sometimes instead of just restricting a user to access a certain area it is needed to hide what they can see. Keep in mind that people in Virtual Reality can walk as well as teleport. If the user teleports right in front of a wall of an apartment in the 30th floor and then just (physically) walks right through it they might be able to see something you, as a developer, do not want them to see, like your skybox without a floor underneath. To avoid this we simply fade out the user's view. 

Let's create such prohibited zone right behind the previously added wall. Create a GameObject called _Prohibited Zone_ place it somewhere behind the wall and add a _BoxCollider_ component to it. Scale the Collider so it at least covers the whole area behind the wall and make sure the Collider is a _Trigger_. This is important! For reference, we placed our _Prohibited Zone_ to (-7, 0, 0) and scaled the added BoxCollider to (7.5, 10, 25). Additionally, add the _FadeOutViewInCollider_ script to the prohibited zone and change it's layer to _IgnoreRaycast_.

Now make usage of VRTK logic to be aware when the user is in the prohibited zone. Create a new GameObject under ```[VRTK_Setup] > [VRTK_Scripts]``` called _HeadsetCollisionFade_. And add the following components with the specific settings:

**_VRTK_PolicyList_** with Include, only check Scripts and as element _FadeoutViewInCollider_ (which we added to the prohibited zone).

**_VRTK_HeadsetCollision_** with a collider radius of 0.001 and the just added PolicyList.

**_VRTK_HeadsetFade_** nothing to adjust here.

**_HeadsetCollisionFade_** with the added VRTK_HeadsetCollision and HeadsetFade and set the _Mode_ to _FADE_WHEN_INSIDE_COLLIDER_.

<p align="center">
  <img width="385" height="581" src="./Documentation/Images/Chapter4_HeadsetFade.png">
</p>

**Solution:** Find the populated scene in _ChapterSolutions/Chapter-4_Get-Around-Your-Scene.unitypackage_.

## <a name="Chapter5"></a>**Chapter 5** Create interactable objects

After we set up a basic scene where you can move around, this chapter covers the process of adding new interactable objects. The goal is to have an interactable wooden box in the scene which can be grabbed, highlighted, scaled and snapped to a pre-defined drop zone. Everything without a single line of code!

We start by creating the interactable box. Drop the _WoodenBox_ prefab into the scene. Now we have to add some components.

**_Rigidbody_** with Drag and Angular Drag set to 3 and gravity turned off. Needed to use some physics on the object.

**_InteractableObject_** with IsGrabbable set to true, so we can actually grab the object.

**_VRTK_FixedJointGrabAttach_** with PrecisionGrab set to true. This allows us to grab the object at the exact position and not snap it to the controller.

**_VRTK_InteractHaptics_** with Strength On Touch and Duration On Touch both set to 0.1. This will give some feedback when we touch the object. 

**_VRTK_AxisScaleGrabAction_** with uniform scaling turned to true. This allows us to scale the object through bi-manual grabbing.

Finally rename the object to _InteractableWoodenBox_ and save it as a prefab for later use. Run the application and see how you can now manipulate your interactable object.

Next create a _SnapDropZone_ to allow the object to be snapped to a certain position. Create a new empty GameObject and call it _WoodenboxDropZone_, assign it a _BoxCollider_ with center (0, 1.375, 0) and size (0.492, 0.33, 0.684), which is 1.2 times the size of the collider of the wooden box. Place the snap drop zone ontop of the table. Additionally, assign a _SnapDropZone_ component to the object and set Snap Duration to 0.5 and Highlight Always Active to true. 

Now you need to add a prefab which is shown as highlight object for the snap zone. Simply duplicate the _WoodenBox_ prefab, rename it to _HighlightWoodenBox_ and assign the _WoodenboxHighlight_ material which is just a transparent material without any textures. In the Highlight Object Prefab of the WoodenboxDropZone choose the newly created prefab.

Finally choose colors for the both highlighting (blue) and valid highlighting (green). Run the application and see what happens when you grab your box, move it close to the snap zone and release it when marked as valid.

**Solution:** Find all created prefabs and the populated scene in _ChapterSolutions/Chapter-5_Create-Interactable-Objects.unitypackage_.

## <a name="Chapter6"></a>**Chapter 6** Flashlight: Create custom tool

In chapter 3 you learned how to use the pen and some other tools which are already included in the _Innoactive Hub SDK_. In this chapter you will develop your first custom tool - a flashlight. This will require your first lines of code.

Drop the already prepared flashlight prefab into the scene and make it interactable, just like in the previous chapter. Add Rigidbody, InteractableObject and VRTK_FixedJointGrabAttach, but instead of VRTK_AxisScaleGrabAction add VRTK_SwapControllerGrabAction, since we do not need scaling but want to swap between the grabbing hands. This time you also do not need VRTK_InteractHaptics necessarily.

Add a SpotLight component to the Flashlight, position it properly at the tip of the flashlight and change the color to make it a slight yellow. Run the application, grab the light and move around. You just created your first _stupid_ tool.

Now add some logic. Open up the _Flashlight_ script in the folder _Scripts_. Notice how it inherits from _InteractableObject_, so all we do is extend the already attached InteractableObject to give it more functionality but still keep interaction consistent between all objects.

**Note:** You will find TODOs in the already prepared scripts which describe how and where you need to add logic. Therefore, this written documentation will be kept a bit shorter but the intended behavior will be described. We left some basic concepts out but make sure to go through the complete script to understand the logic completely. The solution package will have the fully implemented script.

The flashlight should be turned off from the beginning and the size/spread angle of the spotlight should be set to it's initial value as set in the Unity Editor. When the tool is used the light is supposed to be turned on. We also want the spread angle to be adjustable.

When you are done implementing the logic, switch back to Unity and exchange the InteractableObject script with the new Flashlight script on the flashlight GameObject. Enable grabbable, usable and hold button to use to make your tool interactable. Set your spot light as Light to Toggle, too.

**Solution:** Find the implemented script and the populated scene in _ChapterSolutions/Chapter-5_Create-Interactable-Objects.unitypackage_.