# Innoactive Hub SDK Unity Tutorial

**Important: This tutorial is a living project and is changed over time. We are happy about feedback and will provide support through _support@innoactive.de_.**

This repository provides a step-by-step guide to start developing with the _Innoactive Hub Unity SDK_. 

You will learn how to setup your Unity project with the _Innoactive Hub_ and create Unity scenes, populate them with interactable objects and your own tools and how to persist them. Furthermore, we cover multiplayer capabilities, our extendable XML menu as well as the context menu and many more features.

The tutorial is split into chapters, where every chapter builds upon the previous ones. We do not want you to just read code but learn how to use the _Hub_ by implementing yourself. Therefore, we provide stub code in (almost) every chapter and an explanation on what to do. Just follow the instructions of each chapter. Most chapters also come with a unitypackage which includes our suggested solution.

The tutorial is currently based on version **4.0.0** and will be kept up to date in the future. **Note:** It may or may not work with older and later versions of the SDK. If you encounter any problems,  please contact us via the [support portal](https://jira.innoactive.de/servicedesk/customer/portal/3).

# Overview

The _Innoactive Hub Unity SDK_ is based on [VRTK](https://github.com/thestonefox/VRTK) to provide an easy entry point into Virtual Reality interactions as well as development for multiple Head Mounted Displays (HMD).

Additionally, Photon as a proven network technology is used to guarantee stable multi-user experience.

# What you need to start

To complete the whole tutorial simply clone this repository into an empty Unity project. Additionally you will need:

* Innoactive Hub SDK v4.0.0 as explained in [Chapter 1](#Chapter1)
* [SteamVR Unity Plugin v1.2.3 [deprecated]](https://github.com/ValveSoftware/steamvr_unity_plugin/releases/tag/1.2.3)
* Photon Credentials provided by Innoactive
* Innoactive Hub Client Credentials
* Innoactive Hub Web Management Console Credentials
* Innoactive Hub Reality ID
* Unity 2018.3 (our recommended version)

<div style="page-break-after: always;"></div>

# Table of contents

&nbsp; [**Chapter 1** Setup Unity project](#Chapter1)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **1.1** Importing dependencies

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **1.2** _Innoactive Hub SDK Wizard_

[//]: # (&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **1.3** Photon Settings)


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

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **5.2** Snap drop zones


&nbsp; [**Chapter 6** Flashlight: Create custom tool](#Chapter6)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **6.1** Create interactable flashlight

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **6.2** Add logic to your tool


&nbsp; [**Chapter 7** Context Menu](#Chapter7)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **7.1** Default context actions

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **7.2** Custom context actions


&nbsp; [**Chapter 8** Main menu](#Chapter8)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **8.1** Create your own menu

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **8.2** Add tool to menu

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **8.3** Custom menu actions


&nbsp; [**Chapter 9** _Innoactive Hub_ Backend Setup](#Chapter9)

&nbsp; &nbsp; _**Note:** You can only complete this chapter if you have access to the Innoactive Hub Backend_

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **9.1** Client config, login check and login scene

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **9.2** Realities, Spaces and Environments

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **9.3** Load backend content

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **9.4** Access and populate your Web Management Console


&nbsp; [**Chapter 10** Persistence](#Chapter10)

&nbsp; &nbsp; _**Note:** You can only complete this chapter if you have access to the Innoactive Hub Backend_

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **10.1** Save and load space

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **10.2** Persist tools and objects

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **10.3** Scene navigation


&nbsp; [**Chapter 11** Multi-User](#Chapter11)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **11.1** Multi-user sessions and Photon config

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **11.2** Make basic objects networked

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **11.3** Make tools networked


&nbsp; [**Chapter 12** Window System](#Chapter12)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **12.1** Window Factory

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **12.2** Add Buttons

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **12.3** Add to menu


&nbsp; [**Chapter 13** Customize Controllers](#Chapter13)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **13.1** Create new controllers

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **13.2** Controller config and controller config chooser


&nbsp; [**Chapter 14** Spectator](#Chapter14)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **14.1** Setup a spectator

<div style="page-break-after: always;"></div>

## <a name="Chapter1"></a>**Chapter 1** Setup Unity project

After opening the Unity project you will find some folders like Materials, Models, Prefabs etc. in your project structure. You can ignore these for now.

### Importing Innoactive Hub SDK

To start setting up your project, download your version of the _Innoactive Hub Unity SDK_ from http://developers.innoactive.de/. Import the unitypackage by dragging it into your Unity project and wait till it is imported. _Reminder:_ In this tutorial we use version 4.0.0.

The Hub SDK will be imported into _Assets/Extensions_ which is also what we recommend. An error will pop-up which can be ignored for now.

### Importing Steam VR

Download and import _Steam VR_ version 1.2.3 from https://github.com/ValveSoftware/steamvr_unity_plugin/releases/tag/1.2.3. We recommend moving the Steam VR folder into _Assets/Extensions_, right next to the Hub SDK. You should then restart Unity to make sure everything was imported correctly.

**Important**: Steam VR version 2 which is available on the Asset Store is not supported by VRTK 3.3.0 as currently used in the _Innoactive Hub SDK_.

After the Hub SDK as well as Steam VR is imported we take care of the following error (if it is shown):

```Assets/Extensions/hub-sdk/SDK/Utils/UnityDotNetCheck/UnityDotNetCheck.cs(6,0): error CS1029: #error: 'This Unity project is configured for .Net 2.0 subset, but the Innoactive Hub SDK requires full .Net functionality. Please go to "PlayerSettings > Other Settings" and change Api Compatibility Level to .Net 4.0'```

Go to the Unity PlayerSettings and change the Api Compatibility Level in Other Settings from _.Net 2.0 Subset_ to _.Net 4.0_.
The error message can look a little different on your machine, thus we recommend to read it and use the suggested Api settings.

**Note:** For newer Unity versions (2018.3+), it is required to add the *OpenVR* package from the Unity Package Manager in order to get SteamVR running.

**Note:** After compiling another error _might_ pop-up:

```error CS2001: Source file `Assets/Extensions/hub-sdk/Extensions/VRTK/Assets/VRTK/Examples/ExampleResources/SceneResources/[001 - Interactions] ControllerEvents/Scripts/VRTKExample_ControllerEventsDelegateListeners.cs' could not be found.``` 

This is unfortunately a really annoying error with too long filenames which cannot be handled by the system. The easy solution is to move your whole Unity project to a shorter absolute path like ```C:\Users\User\Documents\MyHubTutorial``` or simply delete the VRTK examples.

### Hub SDK Wizard

To make your life easier we included the _Hub SDK Setup Wizard_ which helps you to setup your project. You can find it by clicking on ```Innoactive > Hub > Setup Wizard```. The Wizard will pop-up and show you a list of settings with errors and warnings. We can ignore most of them for now (especially because they are automatically created for you) but want to explain some important ones.

The _Hub Settings_ are your central point for general settings within your application. You can set specific build settings, colors to customize your experience, standard menu actions etc. Most of this will be covered in later chapters.

The _Hub Client Credentials_ are your personal credentials to access the backend which you get from your Innoactive contact person. It is recommended to use the wizard to populate these values but also possible to alter/include the client-config.json file in _Hub-Tutorial-Unity-Project/Config_. The file gets created as soon as the wizards save button is pressed.

As mentioned before Multi-User is based on _Photon_. To configure your multi-user settings we use another config file which you can also find in _Hub-Tutorial-Unity-Project/Config_ (after you clicked on save in the SDK Wizard). For now multi-user is disabled but will be explained in [**Chapter 11**](#Chapter11).

So for now just enter your _Hub Client Credentials_ and click on save on the bottom of the _Hub SDK Wizard_. The rest is handled for you. Just to be safe you should check your _Photon Settings_ in _Hub-Tutorial-Unity-Project/Config/photon-config.json_ and make sure _hosting_ is set to _"OfflineMode"_.

<div style="page-break-after: always;"></div>

## <a name="Chapter2"></a>**Chapter 2** Setup Unity scene

Open the scene _TutorialScene_ in your projects _Scenes_ folder. This is a clean standard Unity scene.

Since we are developing a Virtual Reality application based on _VRTK_ start by removing the _Main Camera_ in the scene and save. We will not need the standard camera.

Next we setup the scene so we can use all features of the _Innoactive Hub_. We took over this process for you to make sure you have everything you need and are good to go. Clicking ```Innoactive > Hub > Setup > Setup Current Scene as Hub Scene``` populates your scene with a bunch of GameObjects which we briefly explain.

### Components
* **[HUB-BOOTSTRAP]** is responsible for scene initialization - handles setup of persistence and multi-user, and loading of the correct space (especially for multi-user sessions).

* **[HUB-MULTIUSER]** is responsible for managing multi-user sessions.

* **[HUB-PERSISTENCE]** handles storing and restoring scene states (i.e. saving/loading).

* **[HUB-LOGIN_CHECK]** ensures that a connection to the _Innoactive Hub_ backend is possible. If not, it will redirect to a login scene.

* **[HUB-DEBUG_UI]** provides a Debug Info overlay when pressing _Ctrl+G_.

* **[HUB-BUG_LOGGING]** Allows to save Debug Logs when pressing _Alt+B_.

* **[HUB-VR-LAUNCHER-CLIENT]** allows connecting to the _Innoactive Hub Launcher_, allowing to switch to different VR applications.

* **[HUB-PLAYER-SETUP-MANAGER]** is responsible for setting up the cameras. This includes but is not limited to disabling the HMD if so selected in the player-config.json as well as enabling / disabling the high-resolution spectator view (also configured via the player-config.json) which shows an interpolated first person view in the native resolution of the attached monitor.

* **[HUB-MENU-SETUP]** allows configuration of the menu to use, and also allows configuring the user menu.

* **[VRTK_Setup]** manages the run-time setup and configuration of VR cameras and interactions.

<br>

<span style="color:red">**IMPORTANT:**</span> Disable **[HUB-LOGIN_CHECK]** and **[HUB-VR-LAUNCHER-CLIENT]** for now. We will come back to those later in [**Chapter 9**](#Chapter9).


**Note:** Setting up the scene before importing _Steam VR_ might mess up [VRTK_Setup]!

### Environment

To make your scene a less empty space add a simple floor. You can find one in the _Prefabs_ folder and drag it into the scene.

**Solution:** Find the initially setup scene in _ChapterSolutions/Chapter-2_Setup-Unity-Scene.unitypackage_.

<div style="page-break-after: always;"></div>

## <a name="Chapter3"></a>**Chapter 3** Explore the basics

This chapter is all about exploring the basic features of the _Innoactive Hub_ and will show you what is possible even without writing a single line of code. Start the application by clicking the Play button in Unity. 

First we cover the teleporter, since we all know getting around a virtual space does not work with just walking. We assume you are using a _HTC Vive_ - button configuration may vary between HMDs. Press the Trigger (with your index finger) to show the teleporter and release to teleport to the circled area. Teleport around the floor a bit to get used to it.

Next let's focus on one of the core features. Touching the Trackpad will open the _Main Menu_. You will see different categories and can navigate through the menu by swiping right, left, up and down on the Trackpad. Navigate to Tools and spawn a Pencil tool by selecting it and pressing the Trackpad.

If no menu appears, make sure the HubDefaultMenuBundle is set in the Menu Settings inside the Hub-Settings of your project.

The menu grants you access to all kinds of Assets, like Tools, 3D Objects, Images, Videos, PDFs, other Scenes and many more. You can change and extend the menu as you like which will be covered in [**Chapter 8**](#Chapter8).

After you spawned the pen you can grab it by touching it (it will get highlighted) and then pressing the grip button on the side of your Vive Controller. We included an optional smart grab functionality which is enabled by default. You can either grab an object by keeping the grip button pressed or by quickly clicking the grip button. Try it out and see the difference. By clicking the grip button again you will release the object.

Using an object is as simple as grabbing one. If you released the pen, grab it again and use the Trigger to draw some lines in your virtual space. You will draw as long as you keep the Trigger pressed.

In addition to the Main Menu, which is a global menu, there is the object-based _Context Menu_. You can open an object's Context Menu by either touching or grabbing it and then touching the Trackpad of your controller. Besides default features like deleting and enable gravity you can add object specific behavior. For example you can change the pen's color, so newly drawn strokes will have a different color. Try it by deleting a previously drawn line and then drawing a new one in another color.

Just play around with the menu and spawned objects and see what you can do with the different things. For instance, spawn a basic shape from the objects menu, change it's color and physics and use bi-manual scaling to make it bigger and smaller (grab it with both hands and move the hands apart). Furthermore, you can change your own representation in VR by changing your avatar in the Avatar menu section. It is also possible to create your own avatar which is a more advanced topic and will not be covered in this tutorial.

<div style="page-break-after: always;"></div>

## <a name="Chapter4"></a>**Chapter 4** Get around your scene

As briefly mentioned in the previous chapter, using the teleporter is your way to get around the scene. But often it is necessary to restrict the user from going everywhere in the scene.

Start by dragging the _Table_ and the _BrickWall_ prefabs into your scene. We obviously do not want the user to stand on top of the table or the wall, so we want to restrict these areas. Add the script _DoNotAllowTeleportingHere_ to both GameObjects to mark them. In VRTK's _Policy List_ for teleport targets (```[VRTK_Setup] > [VRTK_Scripts] > PlayArea > Script VRTK_PolicyList```) you can see that the Check List as well as the checked elements are already set up to disallow teleporting on every object with the just added script. You can of course change that list and add new elements. When copying a string into the field it may happen that an empty space is added at the end. This will cause issues because the Policy List will not handle that properly and recognizes the entered string as different than the one you actually want to ignore. So make sure there is no empty space added.

Sometimes, instead of just restricting a user from accessing a certain area, it is required to hide what they can see. Keep in mind that people in Virtual Reality can physically walk as well as teleport. If the user teleports right in front of a wall of an apartment in the 30th floor and then just physically moves his head, he they might be able to see something you, as a developer, do not want them to see, like your skybox without a floor underneath. To avoid this, we simply fade out the user's view.

Let's create such prohibited zone right behind the previously added wall. Create a GameObject called _Prohibited Zone_, place it somewhere behind the wall and add a _BoxCollider_ component to it. Scale the Collider so it at least covers the whole area behind the wall and make sure the Collider is a _Trigger_ (to prevent it from influencing with the physics simulation). For reference, we placed our _Prohibited Zone_ to (-3.5, 1.5, 0) and scaled it to (0.5, 3, 8). Additionally, add the _FadeoutViewInCollider_ script to the prohibited zone and change its layer to _IgnoreRaycast_.

Now make usage of VRTK logic to be aware when the user is in the prohibited zone. Create a new GameObject under ```[VRTK_Setup] > [VRTK_Scripts]``` called _HeadsetCollisionFade_. And add the following components with the specific settings:

**_VRTK_PolicyList_** with Include, only check Scripts and as element _FadeoutViewInCollider_ (which we added to the prohibited zone).

**_VRTK_HeadsetCollision_** with a collider radius of 0.001 and the just added PolicyList.

**_VRTK_HeadsetFade_** nothing to adjust here.

**_HeadsetCollisionFade_** with the added VRTK_HeadsetCollision and HeadsetFade and set the _Mode_ to _FADE_WHEN_INSIDE_COLLIDER_.

<p align="center">
  <img src="./Documentation/Images/Chapter4_HeadsetFade.png">
</p>

**Solution:** Find the populated scene in _ChapterSolutions/Chapter-4_Get-Around-Your-Scene.unitypackage_.

<div style="page-break-after: always;"></div>

## <a name="Chapter5"></a>**Chapter 5** Create interactable objects


After we set up a basic scene where you can move around, this chapter covers the process of adding new interactable objects. The goal is to have an interactable wooden box in the scene which can be grabbed, highlighted, scaled and snapped to a predefined drop zone. Everything without a single line of code!

We start by creating the interactable box. Drop the _Woodenbox_ prefab into the scene. Now we have to add some components.

**_Rigidbody_** with Drag and Angular Drag set to 3 and gravity disabled. Needed to use some physics on the object.

**_InteractableObject_** with IsGrabbable set to true, so we can actually grab the object.

**_VRTK_FixedJointGrabAttach_** with PrecisionGrab set to true. This allows us to grab the object at the exact position and not snap it to the controller.

**_VRTK_InteractHaptics_** with Strength On Touch and Duration On Touch both set to 0.1. This will give some feedback when we touch the object. 

**_VRTK_AxisScaleGrabAction_** with uniform scaling enabled. This allows us to scale the object through bi-manual grabbing.

Finally rename the object to _InteractableWoodenBox_ and save it as a prefab for later use. Run the application and see how you can now manipulate your interactable object.

**Solution:** Find all created prefabs and the populated scene in _ChapterSolutions/Chapter-5_Create-Interactable-Objects.unitypackage_.

<div style="page-break-after: always;"></div>

## <a name="Chapter6"></a>**Chapter 6** Flashlight: Create a custom tool

In [**Chapter 3**](#Chapter3) you learned how to use the pen and some other tools which are already included in the _Innoactive Hub SDK_. In this chapter you will develop your first custom tool: a flashlight. This is the first programming task in this tutorial.

Drop the already prepared flashlight prefab into the scene and make it interactable, just like in the previous chapter. Add _Rigidbody_, _InteractableObject_ and _VRTK_FixedJointGrabAttach_, but instead of _VRTK_AxisScaleGrabAction_ you can add _VRTK_SwapControllerGrabAction_, since we don't need scaling but want to swap between the grabbing hands. This time you also don't need _VRTK_InteractHaptics_ necessarily.

Add a SpotLight object to the Flashlight, position it properly at the tip of the flashlight and change the color to make it a slight yellow. Run the application, grab the light and move around. You just created your first _stupid_ tool.

Now add some logic.

Add the Flashlight script to the flashlight GameObject. Enable grabbable, usable and hold button to use to make your tool interactable on the _InteractableObject_. Set your spot light as Light to Toggle and the InteractableObject as reference, too.

Open up the _Flashlight_ script in ```Assets > Scripts > Flashlight```. Notice how it has a reference to an _InteractableObject_, so all we do is register to the interaction events to give it more functionality but still keep interaction consistent between all objects.

**Note:** You will find ToDo's in the already prepared scripts which describe how and where you need to add logic. Therefore, this written documentation will be kept a bit shorter but the intended behavior will be described. We left some basic concepts out but make sure to go through the complete script to understand the logic completely. The solution package will have the fully implemented script.

The flashlight should be disabled from the beginning and the size/spread angle of the spotlight should be set to its initial value as set in the Unity Editor. When the tool is used the light is supposed to be enabled. We also want the spread angle to be adjustable.

<div style="page-break-after: always;"></div>

### Add a SnapDropZone

Next, create a _SnapDropZone_ to allow the object to be snapped to a certain position. Create a new empty GameObject and call it _ChargerSnapDropZone_, assign it a _SphereCollider_ with center (0, 0, 0) and radius 0.1 and make it a trigger. Place the SnapDropZone on top of the table, for example at (-0.5, 0.9, -2). Additionally, assign a _ConditionalSnapDropZone_ component to the object, set Snap Duration to 0.2 and Highlight Always Active to true.

Now you need to add a prefab which is shown as highlight object for the SnapDropZone. Simply duplicate the _Flashlight_ prefab, rename it to _HighlightFlashlight_ and assign the _FlashlightHighlight_ material which is just a transparent material without any textures. In the Highlight Object Prefab of the _FlashlightCharger_, choose the newly created prefab.

Finally, choose colors for the both highlighting (blue) and valid highlighting (green) with transparency. Run the application and see what happens when you grab the flashlight, move it close to the SnapDropZone and release it when marked as valid.

At this point, the SnapDropZone accepts all kind of objects, including pencils and other tools. In order to restrict it, add a _HasLabelsConditionComponent_ and add "Flashlight" to the expected labels. Now the SnapDropZone will only accept objects with a _Labeled_ Component containing the given "Flashlight" tag. Make sure to add the _Labeled_ Component to your flashlight prefab as well and add "Flashlight" to the Labels List.

Optionally, a _IsWithinAngleConditionComponent_ can be added to the _FlashlightCharger_ in order to force the user to put the objects in an approximatelly correct orientation. 45 is a good value for the angle threshold.

**Note:** Custom conditions can be easily created by implementing the _ICondition_\<T> interface. For more information, checkout the [_Conditions Documentation_](http://docs.hub.innoactive.de/v4.0.0/articles/conditions.html).

### Charge the flashlight battery

As you may have noticed, the flashlight battery is not fully loaded and prevents us from using it for a long time. Let us make the _FlashlightCharger_ charge the flashlight while it is snapped. For this, simply add the _BatteryCharger_ script. This script is already fully implemented and serves as a reference on how to link objects with snap drop zones.

In order to make the charger look better, add the _FlashlightRecharger_ mesh from the ```Assets > Models > FlashLightRecharger > Meshes``` folder as a subobject to the SnapDropZone.

**Solution:** Find the implemented script and the populated scene in _ChapterSolutions/Chapter-6_Create-Custom-Tool.unitypackage_.

## <a name="Chapter7"></a>**Chapter 7** Context menu

As you probably noticed, you can turn the flashlight on and off but not adjust the spread angle or even delete the flashlight. That's why this chapter covers the implementation and extension of the object-based [_ContextMenu_](http://docs.hub.innoactive.de/v4.0.0/articles/context-menu.html).

First give the default context actions a look and add the _DefaultContextActions_ component to your flashlight. This will also add the _ContextMenuHandler_ automatically. Disable Use, Scale, Clone and Align, which we do not need. You will see now that those default actions are shown in the context menu of the flashlight.

Open the Hub-Settings which were created in [**Chapter 1**](#Chapter1). Here you can change the default color of your menu items for all objects and the default context actions for objects spawned from the menu.

After making sure all default actions are working, let's take care of customizing the context menu. Open up the _FlashlightContextMenu_ script and go through the ToDo's. Notice that the menu inherits _IContextMenuAction_ and has a priority field. The priority defines the position of the action within the menu.

The desired look are two new added buttons with the default design. One button to increase and one to decrease the spread angle of the light, you can use the icons we provided in ```Assets > Resources > Icons``` and call the buttons _Decrease Angle_ and _Increase Angle_. Additionally, the spread angle should be capped at a maximum and minimum value.

Finally, add the script to the flashlight object.

**Solution:** Find the implemented script and the populated scene in _ChapterSolutions/Chapter-7_Use-Context-Menu.unitypackage_.

<div style="page-break-after: always;"></div>

## <a name="Chapter8"></a>**Chapter 8** Main menu

You now created your first fully functional tool as an object in the scene which is always at the same position. The goal is to be able to spawn the flashlight directly from the _Main Menu_ just like all the default tools.

To make the main menu adjustable and extendable we decided on a XML based solution. You can read everything about it in the [_Main Menu Documentation_](http://docs.hub.innoactive.de/v4.0.0/articles/menu.html). In this tutorial we will just cover some basic concepts.

You need to create your own menu first. To do this choose ```Innoactive > Hub > UI > Create XML Menu``` to open the menu creation window. The _Menu Bundle ID_ is basically the name of your menu. For this tutorial set it to _Tutorial_. You also want to make use of the default _Innoactive Hub_ menu to reduce work and to get the same behaviour. Therefore, leave Inherit from other Menu enabled and choose _Hub_ for Bundle Id and _MainMenu_ for Base Main Menu. This simply, as the name says, inherits from the standard menu and provides a good starting point for you.

<p align="center">
  <img src="./Documentation/Images/Chapter7_XMLMenuWizard.png">
</p>

After you clicked _Create Menu_ the XML description of your new menu will be created in ```Assets > Menu > Resources```. Additionally, a ScriptableObject _TutorialMenuBundleSource_ is created in ```Assets > Menu```. Next choose _Set Menu for current Scene_. You will see in your _[HUB_MENU_SETUP]_ GameObject that your XML menu is set in the Runtime Menu Setup. This currently is just a copy of the default menu. Open your menu and also the default Hub menu (```Assets > Extensions > hub-sdk > SDK > UI > Menu > Resources > Menu > HubDefaultMenu.xml```) for reference. Make sure you have a _MainMenu_ section which extends _Hub.MainMenu_. You can leave it empty but need to provide this section. Make sure to check Hub Menu Settings ```Innoactive > Hub >Setup > Highlight Hub Settings```. The Menu Bundle Sources Size should be set to 1 and the the TutorialMenuBundleSource should be added as an Element.

### Extend the menu

The first step to extend your menu, is to add your flashlight as a new tool. Before we can do this we need to add it as a Resource. Remove the Default Context Actions (but leave the custom ones) from your flashlight object in the scene and save it as a new Prefab in ```Assets > Resources``` (create a new folder). We do not need the default actions anymore because they are automatically added when the object is spawned from the menu. You can delete the flashlight in the scene now. Keeping them on the object will overrule the automatic override which can be usefull when some objects should work differently than the default.

To properly show the flashlight within the menu a thumbnail is useful. Duplicate the _clean_ flashlight from the Prefabs folder which does not have any scripts, rename it to _FlashlightThumbnail_ and move it to the just created Resources Prefab folder. Reset its position to (0, 0, 0) and set rotation to (-35, -90, 0). This way it will look a bit more fancy when displayed in the menu. Also remove every collider on the object and all of its children.

Now open your _TutorialMenu.xml_ and the _TutorialMenu_ToDos.xml_ to see what is to do to show the flashlight in the menu and actually spawn it on click. As said before, we also suggest opening the _HubDefaultMenu.xml_ for reference.

First extend the _ToolsMenu_ section by extending as well as replacing the _Hub.ToolsMenu_ to keep all its elements but to be able to add new ones. Then add a new _MenuItem_ which is actually a _DefaultResourceSpawnButton_ with an Id and make sure it is always placed first. Furthermore, include the flashlight resource, a description text ("Flashlight") and the thumbnail. This will do exactly what it says: Create a button with the thumbnail as icon and the text as _title_ which spawns the created prefab on click. _Hint:_ Keep in mind, you can always peek into the implementation of the default menu.

Run your application and try out your new tool spawned from the Tools section of your menu. You will also see that it has all context menu actions.

### Custom menus

You can customize your menu even further by adding your own submenus to it. The goal is to have a submenu of the main menu that has multiple buttons which change the light settings of the scene, switching between day and night. Make sure to add the LightSetupController prefab to your scene, and delete the original Directional Light to avoid interferences with the new lighting. You can access the _LightSetupController_ script by calling ```LightSetupController.Instance_```. Open the _CustomLightSetupMenu_ script which already inherits from _Menu_ and _IMenuProvider_. Implement the ToDo's for [**Chapter 8**](#Chapter8) and ignore the ones from [**Chapter 12**](#Chapter12) which we will tackled later on to extend this feature.

To add new buttons to the custom menu use the _Menu.Add()_ method with _ButtonItem_ as _MenuItem_. For the Icon simply use the _ResourceIcon_ with a descriptive text ("Day"/"Night") and the icons from ```Assets > Resources > Icons > day/night-icon``` and for the action make use of the _SetLight_ method.

The logic of the menu is now done but you will not see it in the application yet. Jump back to the XML description of the menu and add a new _MenuItem_ to your _MainMenu_. Provide an Id for the MenuItem which is actually a _DefaultLink_. A DefaultLink references a Menu and includes it. See the structure of the link in the _HubDefaultMenu_. For the Behaviour you need the provider which points to the Menu class (including its namespace) you want to add and for the _Content_ add a text (in our case "Light Menu") and an icon where you can simply use the spaces icon (```... > menu > Icons > SpacesIcon```).

Run the application and open your menu. You will see a new entry at the end of the list. Navigate to it and make use of the two newly added menu functions.

**Solution:** Find the implemented script, menu and the cleaned scene in _ChapterSolutions/Chapter-8_Use-Main-Menu.unitypackage_.

<div style="page-break-after: always;"></div>

## <a name="Chapter9"></a>**Chapter 9** _Innoactive Hub_ Backend Setup

This chapter is all about setting up your _Innoactive Hub_ Backend and how to make use of it.

**Note:** Get your client credentials from your _Innoactive_ contact person or you will not have access to the _Web Management Console_.

There are two ways to configure your client settings, the settings you need to make to have actual access. 

The first and recommended option is to open up the SDK Setup Wizard again and fill in the _Hub Client Credentials_, if not already done in Chapter 1. You get the Hub URL, the Client Id as well as the Secret from your _Innoactive_ contact person. The values you enter here will be copied into the client config file (```Project > Config > client-config.json```) which is also the second option. You can just include everything in this file directly without using the Wizard.

Enable the _[HUB-LOGIN-CHECK]_ object in your scene and open up the Hub-Settings in your project. Include your provided reality into the _Editor Reality Id_ field.

**Note:** The authorization with the backend will require loading a new scene, *LoginSceneAuthCode*.
For this to work, both your tutorial scene and the login scene must be added to your project's build settings.

> A reality is one _unique_ version of your application. You can see realities as parallel universes. While in Reality A you have three pens, a flashlight and some drawings floating around, in reality B you only moved your box right next to the wall and have a measuring tape to check the distance to your table. Both realities build upon the same basic scene/application and exist next to each other but the states of the objects are different. This allows multiple people to work within the same application without interfering with each other. Realities do not know each other and within one application you cannot jump between realities!

Start your application and open your menu. You will see new entries which you can only use when you have access to the backend. Spawn some models, images or presentations from the backend just like you did with _local_ resources. To populate your scene with your own objects open up your _Web Management Console_ (WMC) online and upload a new model. When you are all done run the application again and see how your just added object is already available in the menu without changing the application at all.

**Solution:** Find the scene with activated login check in _ChapterSolutions/Chapter-9_Innoactive_Hub_Backend_Setup.unitypackage_. _Note:_ You still need to setup your client config credentials by hand.

<div style="page-break-after: always;"></div>

## <a name="Chapter10"></a>**Chapter 10** Persistence

Persistence is the idea of loading and saving states of the current environment and one of the most important concepts of the _Innoactive Hub_. We call those states _Space Versions_. You can see a Space Version as a save state/game of your current space. Therefore, a Space Version can be saved as well as loaded and will be uploaded to the _Innoactive Hub_ Backend to use at a different time.

To get into more detail, a Space Version has objects and those objects have properties. Each property defines a special state of the object like location, physics, color, grabbability etc. By default all spawned objects are persisted. Thereby, the _PersistenceManager_ acts as the central component. You can save a Space Version explicitly through the menu. By default a Space Version is saved when you leave your environment or quit your application.

_Note:_ Find more information in our official [documentation](http://docs.hub.innoactive.de/v4.0.0/articles/persistence.html). To allow persistence to work, one must have a scene object that manages the persistent scene.
You probably remember that we already added such an object in Chapter two, the _[HUB-PERSISTENCE]_ object. Feel free to take a look at it and make sure that it's active before you proceed.

### Save and load

Loading is done by the _SceneNavigationManager_ which has actions to load a certain Space Version by Id but typically the last saved Space Version is loaded. While being in multi-user, every user in the same room loads the same Space Version.

The goal of this chapter is to first save a Space Version and then load it again via the menu. Additionally, the flashlight from [**Chapter 6**](#Chapter6) will be persisted and you will learn how to switch between scenes without losing the changes made before.

Let's start by spawning some tools and moving them around. Then open the menu and save your Space Version. You can load the Space Version by selecting ```Load Previous State```, choosing a saved state to go back to and putting the spawned space sphere over your head.

### Make tools persistent

As you may have noticed, your flashlight tool keeps its position but not its last set state and spread angle. This might not be a huge issue for the flashlight, but for more complex objects/tools or for colored things it can be vital.

To make a tool persistent, it needs its own _PropertyData_ as well as _Translator_. Open the _FlashlightPersistenceData_ script which already inherits from _PersistentProperty.PropData_ and carries the _DataContract-Attribute_. In here you actually just have to create nullable types (by adding a ? after the type like _Color?_) that you want to persist within your flashlight, so your state and your spread angle. You have to mark both properties with _DataMemberAttribute_ in the same way as in the BatteryPersistenceData. Make data members's names unique. As you can see _PropertyData_ is more or less a container which holds the information you want to persist.

The translator does the actual work. Edit your _FlashlightPersistenceTranslator_ which in this case is a _SingleComponentPropertyTranslator_ with the _FlashlightPropertyData_ as well as the _Flashlight_ component. Start by returning the correct _PropertyTypeName_ which is defined in the data.

The other two ToDo's are, simply said, one to get the data from the object and save it (_UpdatePropertyFromComponent_) and the other to load the object data which was saved before (_UpdateComponentFromProperty_). So in _UpdatePropertyFromComponent_ set the property data to the components current values and in _UpdateComponentFromProperty_ set the current values to the saved property data.

This now handles the storing and loading of data in general but will not be called by the _PersistenceManager_ yet. We first have to register the translator. Open the _TutorialPersistenceExtension_ script which inherits from _PersistenceConfigExtension_ and add the _FlashlightPersistenceTranslator_ to the config by registering it. You need to register every tool and object you want to persist and which required a _PersistenceTranslator_ within the extension.

The last step to have your flashlight persisted is to add the  _TutorialPersistenceExtension_ component to some object in your tutorial scene (as well as in the Login scene).

**Solution:** Find the implemented scripts and the updated scene in _ChapterSolutions/Chapter-10.1_Persistence_Tools.unitypackage_.

### Jump between scenes

_Note:_ Make sure your _TutorialScene_ as well as _TutorialScene2_ are added to the BuildSettings.

The last thing covered in this chapter is how to switch scenes. You can change scenes with the _SceneNavigationManager_ in your code or, as done in this tutorial, through the menu. Open your XML menu again and extend your previously edited _MainMenu_ further. Add two new entries which are basically the same but differ in the scene they are loading. Create a default button with environment condition which hides the button if your current environment/scene is the same as the one to load. Therefore, you cannot switch to a scene you are already in. For the behaviour use a local CommandBehaviour, loading the last saved space without saving when loading. Name the button "Go to Tutorial 1" and use the simple icon with the number 1. Do the same for the scene _TutorialScene2_ which you can find in the same folder and is an empty scene just to show how to switch scenes. 

**Solution:** Find the extended menu in _ChapterSolutions/Chapter-10.2_Persistence_Switching-Scenes.unitypackage_.

<div style="page-break-after: always;"></div>

## <a name="Chapter11"></a>**Chapter 11** Multi-User

Up to now everything so far was in offline mode, so not networked and not intended for multiple users in the same application. Let's switch to multi-user sessions!


In this tutorial, three different ways of implementing networked methods are covered: event based _RPC_, continuous _StateSynchronization_ and _HubCommands_. Every method has its own use case and is shown in this chapter.

The _Innoactive Hub SDK_ is built upon _Photon_ for networking and multi-user capabilities. To get started with multi-user, open your _photon-config.json_ in the project's _Config_ folder where hosting is currently set to _OfflineMode_. Change it to either _SelfHosted_ or _PhotonCloud_ depending on your preferences and update your _appId_ (and _serverAddress_ if you prefer _SelfHosted_) or use the photon credentials you were given. Save the config, find a friend and start your application to meet in the virtual world. You probably notice that the wooden box is not networked and moving it will only be done for the local user while objects spawned from the menu are automatically networked.

Adjusting an object to make it multi-user ready is quite simple. Add an _InteractableObjectNetworking_ component to the wooden box which automatically attaches a _PhotonView_. This will synchronize the transform between all users but the snapping to the drop zone is still missing. Continue by adding a _SnapDropZoneNetworked_ component to the _ChargerSnapDropZone_, run the application and see how other people can manipulate objects within the same scene.

### Flashlight networking with RPCs

When you spawn your flashlight you can see that it automatically gets an _InteractableObjectNetworking_ and moving the object is networked but the state as well as the spread angle are not. Therefore, those special functionalities have to be synchronized _by hand_. Open the _FlashlightNetworking_ script which already inherits from _InteractableObjectNetworking_ and thus just the special behavior has to be implemented.

First, it is important to know when and what has to be networked and when other users have to be notified. Since it is not necessary to constantly synchronize the current spread angle even though it does not change, subscribe in _OnEnable_ to the flashlight events created in [**Chapter 6**](#Chapter6) - and unsubscribe _OnDisable_. Within the class you find already two methods which should be called when the appropriate events are fired.

Let's focus on the callback method which handles the spread angle first which will make use of _Photon's RPC_. Here you can make use of the attached _PhotonView_ and call its method _RPC_ with the name of the method to call (in this case "RemoteSpreadChanged"), who is the receiver of this call (only other players, since the local user has already changed the angle) and the new angle which you can get from the passed arguments. That is all you have to do when making use of _Photon_.

The remote method is similar. It has a _[PunRPC]_ attribute, so it is registered for each user and therefore can be called with _Photon's RPC_ functionality. Here you just have to change the spread angle of the flashlight. The same applies to the _RemoteChangeLightState_. It gets the new light state and simply sets it in the local flashlight.

As you probably noticed you can get into a nasty recursion, since one user for example changes the spread angle of the flashlight and fires the matching event. Then the networked flashlight makes sure all other users update their flashlights which triggers the event again and therefore notifies the _FlashlightNetworking_ which tries to synchronize its state with the other users. Thus we introduce a simple recursion lock flag which secures that things are only executed when they should. Hence, activate the recursion lock before you update the local flashlight, deactivate it afterwards and ensure that the callbacks are only executed when the recursion lock is inactive.

Finally, add your _FlashlightNetworking_ script to the flashlight prefab and disable _Synchronize Usage_ for testing purposes. Run your application and try your new networked tool.

### Battery networking with state synchronization

In order to get the Battery networked as well, add the _BatteryNetworking_ component to the flashlight and go through its TODO's.

**Note:** The battery networking works via Photon state synchronization. Check out the [_Photon Documentation_](https://doc.photonengine.com/en-us/pun/v2/getting-started/pun-intro) for more information.

### LightSetup networking with Hub Commands

Currently, the light setup change is not networked.

Open the _LightSetupCommand_ class which inherits from _HubCommand_ and go through its TODO's. A _HubCommand_ is basically a command which can be configured and then executed for every user.

The command is now ready but still needs to be executed. Open the _CustomLightSetupMenu_, remove or comment out the _SetLightSetup_ implementation from [**Chapter 8**](#Chapter8) then create and execute a _LightSetupCommand_ instead. Make sure to pass the _lightSetupIndex_ to the command before executing it.

Executing the _Hubcommand_ will automatically propagate to other users. 

**Solution:** Find the implemented script and updated prefab in _ChapterSolutions/Chapter-11_Multi-User.unitypackage_.

<div style="page-break-after: always;"></div>

## <a name="Chapter12"></a>**Chapter 12** Window System

This chapter covers one of the many helper and utility features within the _Innoactive Hub SDK_ which will make your life easier. Sometimes you might want to show a notification, dialog or error message for the user in the virtual environment. The [_WindowFactory_](http://docs.hub.innoactive.de/v4.0.0/api/Innoactive.Hub.UI.WindowSystem.WindowFactory.html) will save you a lot of time and also keeps your messages consistent.

To demonstrate how the _WindowFactory_ works, we have created the _InfoWindow_ component. It is meant as example to give an idea about how to use it. Just drag it onto some object in your scene. When playing the application, a window should open after the defined delay time.

You might not like the current color scheme or it does not fit your company's style. In that case, customize the _WindowFactory_ to your needs. Let's try by settings the background color to black, the text, title and button color to white and the border color to white. Let creativity run wild!

<div style="page-break-after: always;"></div>

## <a name="Chapter13"></a>**Chapter 13** Customize controllers

Currently, when you start an application, controllers with default behavior (default _Innoactive Hub_ configuration) are loaded. This includes how buttons are mapped, how you grab things and how the teleporter works along with a lot of other settings. In some cases you might not want to show a menu or allow only the trigger to be used. Maybe you want to change the appearance of the teleporter or even want your left controller to be different from your right one.

In this chapter you will learn how to change the appearance of your teleporter to the default _VRTK_ look.

You find configured controller prefabs in ```Assets > Extensions > hub-sdk > SDK > Interaction > Controller > Prefabs > Controller```. We assume you are using the _HTC Vive_, so duplicate the _Steam_Vive_LeftController_ as well as the _RightController_, move the copies to ```Assets > Controller``` (create a new folder if needed, the location does not matter though) and rename them to _Tutorial_Vive_LeftController_ and _Tutorial_Vive_RightController_. These will be your new controllers whenever you start the application.

We have to add the controllers to the scene to actualy make use of them. Create a new _PrefabControllerConfig_ in a new folder _Config_ within the _Controller_ folder. Do this by right clicking the folder and choosing ```Create > InnoactiveHub > Controller > PrefabControllerConfig```. Rename the newly created _ScriptableObject_ to _TutorialControllerConfig_. Set the name to _Tutorial_ and drag your prefabs into the controller fields. In your hierarchy navigate to ```[VRTK_SETUP] > [VRTK_Scripts] > ControllerConfigChooser```, expand the Configs section of the _ChooseController_ script and replace the config of _Steam VR_ + _HTC Vive_ with your _TutorialControllerConfig_. From now on, whenever you start your application - or to be more precise this scene, since controller configs are in scene not in project scope - your new custom controllers will be loaded.

The next step is to customize your controllers to see the difference. As mentioned before we simply change the appearance of the teleporter. In both of your custom controllers change the _VRTK_BezierPointerRenderer_ of the _TeleportPointer_ child object. On the bottom of the script you find _AppearanceSettings_ which you can replace with the prefabs in ```Assets > Extensions > hub-sdk > Extensions > VRTK > Assets > VRTK > Examples > ExampleResources > SharedResources > Prefabs > AnimatedBezierPointer```.

<p align="center">
  <img width="414px" height="89px" src="./Documentation/Images/Chapter13_CustomTeleport.png">
</p>

Run your application and teleport around to see the difference. To also make use of the new controllers in the _TutorialScene2_ change the setup accordingly.

**Solution:** Find the new controller prefabs, config and updated scene in _ChapterSolutions/Chapter-13_Customize-Controllers.unitypackage_.

<div style="page-break-after: always;"></div>

## <a name="Chapter14"></a>**Chapter 14** Spectator

The _Innoactive Hub_ is intended for business applications. Even though a user will train or plan in VR on their own they might have someone standing next to them without wearing a HMD, monitoring what the user in VR is doing. Therefore, the _Innoactive Hub SDK_ offers the possibility to show what the user sees on a second display via a spectator. By default a spectator camera is created at run-time and shows what the user sees (with some additional information). Just start your application in the Unity Editor and find a _Spectator Camera_ object in your scene. You can customize this spectator camera by setting your own in the _PlayerSetupManager_ in the _[HUB-PLAYER-SETUP-MANAGER]_ in your scene. Usually this is not necessary but the possibility is given.

You can enable and disable this spectator via the _player-config.json_ which you can find in the _Config_ folder of your project. Since this option is included in the configuration files you can also turn it on and off after the application is built.
