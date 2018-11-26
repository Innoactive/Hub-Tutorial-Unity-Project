# Innoactive Hub SDK Unity Tutorial

This repository provides a step-by-step guide to start developing with the _Innoactive Hub Unity SDK_. 

You will learn how to setup your Unity project with the _Innoactive Hub_ and create Unity scenes, populate them with interactable objects and your own tools and how to persist them. Furthermore, we cover multiplayer capabilities, our extendable XML menu as well as the context menu and many more features.

The tutorial is split into chapters, where every chapter builds upon the previous ones. We do not want you to just read code but learn how to use the _Hub_ by implementing yourself. Therefore, we provide stub code in (almost) every chapter and an explanation on what to do. Just follow the instructions of each chatper. Most chapters also come with a unitypackage which includes our suggested solution.

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


&nbsp; [**Chapter 7** Use context menu](#Chapter7)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **7.1** Default context actions

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **7.2** Custom context actions


&nbsp; [**Chapter 8** Use main menu](#Chapter8)

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **8.1** Create your own menu

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **8.2** Add tool to menu

&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **8.3** Custom menu actions

[//]: # (&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; **8.4** Complex menu actions)

[//]: # (8.4 Maybe show how to make an application quit button or something more stupid but similar. Do this in a future iteration.)


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

Go to the Unity PlayerSettings and change the Api Compatibility Level in Other Settings from _.Net 2.0 Subset_ to _.Net 2.0_.

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

**IMPORTANT:** Disable **[HUB-LOGIN_CHECK]** and **[HUB-VR-LAUNCHER-CLIENT]** for now. We will come back to those later. **If you keep the login check enabled it will try to connect to the backend which is covered in chapter 9.**

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

**Solution:** Find the implemented script and the populated scene in _ChapterSolutions/Chapter-6_Create-Custom-Tool.unitypackage_.

## <a name="Chapter7"></a>**Chapter 7** Use context menu

As you probably noticed you can turn the flashlight on and off but not adjust the spread angle or even delete the flashlight. That's why this chapter covers the implementation and extension of the object-based context menu.

First give the default context actions a look and add the _DefaultContextActions_ component to your flashlight. Disable Use, Scale, Clone and Align, which we do not need. You will see now that those default actions are shown in the context menu of the flashlight.

Open the Hub-Settings which were created in chapter 1. Here you can change the default color of your menu items for all objects and the default context actions for objects spawned from the menu.

After making sure all default actions are working, let's take care of customizing the context menu. Open up the _FlashlightContextMenu_ script and go through the ToDo's. Notice that the menu inherits _IContextMenuAction_ and has a priority field. The priority defines the position of the action within the menu. 

The desired look are two new added buttons with the default design. One button to increase and one to decrease the spread angle of the light. Additionally, the spread angle should be capped at a maximum and minimum value.

Finally, add the script to the flashlight object.

**Solution:** Find the implemented script and the populated scene in _ChapterSolutions/Chapter-7_Use-Context-Menu.unitypackage_.

## <a name="Chapter8"></a>**Chapter 8** Use main menu

You created now your fully functional tool but as an object in the scene which is always at the same position. The goal is to be able to spawn the flashlight directly from the _Main Menu_ just like all the default tools.

To make the main menu adjustable and extendable we decided on a XML based solution. You can read everything about it in the [_Main Menu Documentation_](http://docs.hub.innoactive.de/articles/menu.html). In this tutorial we will just cover some basic concepts.

You need to create your own menu first. To do this choose ```Innoactive > Hub > Create XML Menu``` to open the menu creation window. The _Menu Bundle ID_ is basically the name of your menu. For this tutorial set it to _Tutorial_. You also want to make use of the default _Innoactive Hub_ menu to reduce work and to get the same behaviour. Therefore, leave Inherit from other Menu enabled and choose _Hub_ for Bundle Id and _MainMenu_ for Base Main Menu. This simply, as the name says, inherits from the standard menu and provides a good starting point for you. 

<p align="center">
  <img width="75%" src="./Documentation/Images/Chapter7_XMLMenuWizard.png">
</p>

After you clicked _Create Menu_ the XML description of your new menu will be created in ```Assets > Menu > Resources```. Additionally, a ScriptableObject _TutorialMenuBundleSource_ is created in ```Assets > Menu```. Next choose _Set Menu for current Scene_. You will see in your _[HUB_MENU_SETUP]_ GameObject that your XML menu is set in the Runtime Menu Setup. This currently is just a copy of the default menu. Open your menu and also the HubDefaultMenu (```Assets > Extensions > hub-sdk > SDK > UI > Menu > Resources > Menu > HubDefaultMenu.xml```) for reference. Make sure you have a _MainMenu_ section which extends _Hub.MainMenu_. The Hub Menu Setup as a matter of fact references the _MainMenu_ within the TutorialMenu.xml, thus you actually need to provide this. You can leave it empty but need to provide this section.

The first step to extending your custom menu, is to add your flashlight as a new tool. Before we can do this we need to add it as a Resource. Remove the Default Context Menu Actions (but leave the custom ones) from your flashlight object in the scene and save it as a new Prefab in ```Assets > Resources > Prefabs``` (create a new folder). We do not need the Default Actions anymore because they are automatically added when the object is spawned from the menu. You can delete the flashlight in the scene now.

To properly show the flashlight within the menu a thumbnail is useful. Duplicate the _clean_ Flashlight from the Prefabs folder which does not have any scripts, rename it to _FlashlightThumbnail_ and move it to the just created Resources Prefab folder. Reset its position to (0, 0, 0) and set rotation to (-35, -35, 0). This way it will look a bit more fancy when displayed in the menu. Also remove every collider on the object and all of its children.

Now open your _TutorialMenu.xml_ and the _TutorialMenu_ToDos.xml_ to see what is to do to show the flashlight in the menu and actually spawn it on click. As said before, we also suggest opening the _HubDefaultMenu.xml_ for reference.

First extend the _ToolsMenu_ section by extending as well as replacing the _Hub.ToolsMenu_ to keep all its elements but to be able to add new ones. Then add a new _MenuItem_ which is actually a _DefaultResourceSpawnButton_ with an Id and make sure it is always placed first. Furthermore, include the flashlight resource, a description text ("Flashlight") and the thumbnail. This will do exactly what it says: Create a button with the thumbnail as icon and the text as _title_ which spawns the created prefab on click. _Hint:_ Keep in mind, you can always peek into the implementation of the default menu.

Run your application and try out your new tool spawned from the Tools section of your menu. You will also see that it has all context menu actions.

You can customize your menu even further by adding your own submenus to it. The goal is to have a submenu of the main menu that has multiple buttons which teleports the user to certain positions in the scene. Open the _CustomTeleportMenu_ script which already inherits from _Menu_ and _IMenuProvider_. Implement the ToDo's for chapter 8 and ignore the ones from chapter 12 which we will tackle later on to extend this feature.

To add new buttons to the custom menu use the _Menu.Add()_ method with _ButtonItem_ as _MenuItem_. For the Icon simply use the _ResourceIcon_ with a descriptive text but without any specific icon and for the action make use of the _TeleportTo_ method which you need to implement next.

_TeleportTo_ just gets a destination position but you will need to find the _VRTK_BasicTeleport_ as well as the _PlayArea_ to make use of the teleports _Teleport_ method.

The logic of the menu is now done but you will not see it in the application yet. Jump back to the XML description of the menu and add a new _MenuItem_ to your _MainMenu_. Provide an Id for the MenuItem which is actually a _DefaultLink_. A DefaultLink references a Menu and includes it. See the structure of the link in the _HubDefaultMenu_. For the Behaviour you need the provider which points to the Menu class (including its namespace) you want to add and for the _Content_ add a text (in our case "Teleport Menu") and an icon where you can simply use the number icons (```Icons > icon_1/2/3```).

Run the application move around and open your menu. You will see a new entry at the end of the list. Navigate to it and make use of the three newly added menu functions.

**Solution:** Find the implemented script, menu and the cleaned scene in _ChapterSolutions/Chapter-8_Use-Main-Menu.unitypackage_.

## <a name="Chapter9"></a>**Chapter 9** _Innoactive Hub_ Backend Setup

This chapter is all about setting up your _Innoactive Hub_ Backend and how to make use of it.

_Note:_ Get your credentials or you will not have access to the _Web Management Console_.

There are two ways to configure your client settings, the settings you need to make to have actual access. 

First and recommended option is to open up the SDK Setup Wizard again and fill in the _Hub Client Credentials_. You get the Hub URL, the client Id as well as the secret from your _Innoactive_ contact person. The values you enter here will be copied into the client config file (```Project > Config > client-config.json```) which is also the second option. You can just include everything in this file directly without making use of the Wizard.

Enable the _[HUB-LOGIN-CHECK]_ object in your scene and open up the Hub-Settings in your project. Include your provided reality into the _Editor Reality Id_ field.

> A reality is one _unique_ version of your application. You can kinda see realities as parallel universes. While in Reality A you have three pens, a flashlight and some drawings floating around, in reality B you only moved your box right next to the wall and have a measuring tape to check the distance to your table. Both realities build upon the same basic scene/application and exist next to each other but the states of the objects are different. This allows multiple people to work within the same application without interfering with each other. Realities do not know each other and within one application you cannot jump between realities!

Start your application and open your menu. You will see new entries which you can only use when you have access to the backend. Spawn some models, images, sounds and/or videos from the backend just like you did with _local_ resources. To populate your scene with your own objects open up your _Web Management Console_ (WMC) online and upload a new model. When you are all done run the application again and see how your just added object is already available in the menu without changing the application at all.

**Solution:** Find the scene with activated login check in _ChapterSolutions/Chapter-9_Innoactive_Hub_Backend_Setup.unitypackage_. _Note:_ You still need to setup your client config credentials by hand.

## <a name="Chapter10"></a>**Chapter 10** Persistence

Persistence is the idea of loading and saving states of the current environment and one of the most important concepts of the _Innoactive Hub_. We call those states _Spaces_ or more precisely _persistent Spaces_. You can see a space as a save state/game of your current environment. Therefore, a space can be saved as well as loaded and will be uploaded to the _Innoactive Hub_ Backend to use at a different time.

To get into more detail, a space has objects and those objects have properties. Each property defines a special state of the object like location, physics, color, grabbability etc. By default all spawned objects are persisted. Thereby, the _PersistenceManager_ acts as the central component. You can save a space explicitly through the menu. By default a space is saved when you leave your environment or quit your application.

_Note:_ Find more information in our official [documentation](http://docs.hub.innoactive.de/articles/persistence.html).

### Save, Load and Reset

Loading is done by the _SceneNavigationManager_ which has actions to load a certain space by Id but typically the last saved space is loaded. While being in multi-user every user in the same room loads the same space.

So far for the theory, in practice the goal of this chapter is to first save a space, see how it shows up in the WMC and then load it again via the menu. Additionally, the flashlight from chapter 6 will be persisted and you will learn how to switch between scenes without losing the changes made before.

Let's start by spawning some tools and moving them around. Then open the menu and save your space. Check your WMC and see how it shows up there. But we cannot load it yet. 

As said before, the loading will be done through a new menu button. Start editing your _TutorialMenu_ XML description from chapter 8 and include _SpacesMenu_ which extends _Hub.SpacesMenu_, just like we did with the _ToolsMenu_ before. Include two new buttons, one for actually loading a space and one for resetting your current space to the original state. 

First the loading: Create a default button with Id _Load_. As a condition make sure the user is logged into the _Innoactive Hub_ Backend. This makes the button only visible if the condition is met. Next add a _CommandBehaviour_ with a _NavigationActionCommand_ and loading the last revision of the given Unity scene as action. For scene use the name of your scene (_TutorialScene_). Additionally, make sure the command is only executed locally, so not every other user is forced into the loaded space, and it is not automatically saved when the space is left. As description for this icon use _Load_ and as icon the _Icon_Menu_Download_ which you can find at ```Menu > Icons > Icon_Menu_Download```.

Resetting your space is similar to loading. Again, create a new default button with the same condition and the same command behaviour and the same command type. Make sure it is also only executed for the local player, in the same scene as before and do not save when leaving the space. But for the action make sure this time only the local unity scene is loaded. Call this button _Reset_ and give it the _HomeIcon_ which you can find in the same folder as the other one.

Save your XML file and start your application. Choose _Load_ to load the previously saved state and you will see that your objects will be where you left them before. Now reset your space, load again, reset again and finally save. Now your empty space is your last saved space.

**Solution:** Find the extended menu in _ChapterSolutions/Chapter-10.1_Persistence_Save-And-Load.unitypackage_.

### Make tools persistent

As you might have seen your flashlight tool keeps it position but not its last set state and spread angle. This might not be a huge issue for the flashlight but for more complex objects/tools or for colored things it can be vital.

To make a tool persistent it needs its own _PropertyData_ as well as _Translator_. Open the _FlashlightPersistenceData_ script which already inherits from _PersistentProperty.PropData_ and carries the _DataContract-Attribute_. In here you actually just have to create nullable types that you want to persist within your flashlight, so your state and your spread angle. Both get the _DataMember-Attribute_ with unique names. As you can see _PropertyData_ is more or less a container which holds the information you want to persist.

The translator does the actual work. Edit your _FlashlightPersistenceTranslator_ which in this case is a _SingleComponentPropertyTranslator_ with the _FlashlightPropertyData_ as well as the _Flashlight_ component. Start by returning the correct _PropertyTypeName_ which is defined in the data.

The other two ToDo's are, simply said, one to get the data from the object and save it (_UpdatePropertyFromComponent_) and the other to load the object data which was saved before (_UpdateComponentFromProperty_). So in _UpdatePropertyFromComponent_ set the property data to the components current values and in _UpdateComponentFromProperty_ set the current values to the saved property data.

This now handles the storing and loading of data in general but will not be called by the _PersistenceManager_ yet. We first have to register the translator. Open the _TutorialPersistenceExtension_ script which inherits from _PersistenceConfigExtension_ and add the _FlashlightPersistenceTranslator_ to the config by registering it. You need to register every tool and object you want to persist and which required a _PersistenceTranslator_ wihtin the extension.

The last step to have your flashlight persistet is to add the implemented extension to the [HUB_PERSISTENCE] object in your tutorial scene (as well as in the Login scene).

**Solution:** Find the implemented scripts and the updated scene in _ChapterSolutions/Chapter-10.2_Persistence_Tools.unitypackage_.

### Jump between scenes

The last thing covered in this chapter is how to switch scenes. You can change scenes with the _SceneNavigationManager_ in your code or, as done in this tutorial, through the menu. Open your XML menu again and extend your previously edited _SpacesMenu_ further. Add two new entries which are basically the same but differ in the scene they are loading. Create again a default button with condition but this time it is an environment condition which hides the button if your current environment/scene is the same as the one to load. Therefore, you cannot switch to a scene you are already in. For the behaviour it is the exact same as for Load previously (local CommandBehaviour, loading the last saved space and is not saved when loading a new space). Call the button "Go to Tutorial 1" and use the simple icon with the number 1 again. Do the same for the scene _TutorialScene2_ which you can find in the same folder and is an empty scene just to show how to switch scenes. 

**Solution:** Find the extended menu in _ChapterSolutions/Chapter-10.3_Persistence_Switching-Scenes.unitypackage_.

## <a name="Chapter11"></a>**Chapter 11** Multi-User

Up to now everything so far was in offline mode, so not networked and not intended for multiple users in the same application. Let's switch to muli-user sessions!

## <a name="Chapter12"></a>**Chapter 12** Window System

This chapter covers one of the many helper and utility features within the _Innoactive Hub SDK_ which will make your life easier. Sometimes you might want to show a notification, dialog or error message for the user in the virtual environment. The _WindowFactory_ will save you a lot of time and also keeps your messages consistent.

To demonstrate how the _WindowFactory_ works, extend your custom teleport menu from chapter 8 by adding a new button which will open a dialog window that shows your current position and lets you reset your position to world origin.

So Step by step, start by opening your _CustomTeleportMenu_ script which still has some ToDo's open. Edit the _ShowCurrentPositionWindow_ method and make use of the _WindowFactory_. Create an actions window with a text tells you your current position and rotation and the title _Current Position_. Additionally, add two buttons. One that says _Okay_ and simply closes the dialog box and one that says _Reset_ and teleports you to the world origin (also closing the box afterwards).

Next give the user the possibility to actually open the window. Add a new button to the custom menu with the _SettingsIcon_ which you can find at ```Menu > Icons > SettingsIcon```, the title _Show Position_ and which opens the previously implemented window. Run your app and try it out by opening your menu and navigating to the teleport menu.

You might not like the current color scheme or it does not fit your company's style. In that case, customize the _WindowFactory_ to your needs. Let's try by settings the background color to black, the text, title and button color to white and the border color to white. Let creativity run wild!

**Solution:** Find the updated script in _ChapterSolutions/Chapter-12_Window-System.unitypackage_.

## <a name="Chapter13"></a>**Chapter 13** Customize Controllers

Currently when you start an application, controllers with default behavior (default _Innoactive Hub_ configuration) are loaded. This includes how buttons are mapped, how you grab things and how the teleporter works along with a lot of other settings. In some cases you might not want to show a menu allow only the trigger to be used or change the appearance of the teleporter or even want your left controller to be different from your right one.

In this chapter you will learn how to change the appearance of your teleporter to the default _VRTK_ look.

You find configured controller prefabs in ```Assets > Extensions > hub-sdk > SDK > Interaction > Controller > Prefabs > Controller```. We assume you are using the _HTC Vive_, so duplicate the _Steam_Vive_LeftController_ as well as the _RightController_, move the copies to ````Assets > Controller``` (create a new folder if needed, the location does not matter though) and rename them to _Tutorial_Vive_LeftController_ and _TutorialVive_RightController_. These will be your new controllers whenever you start the application.

We have to add the controllers to the scene to actualy make use of them. Create a new _PrefabControllerConfig_ in a new folder _Config_ within the _Controller_ folder. Do this by right clicking the folder and choosing ```Create > InnoactiveHub > Controller > PrefabControllerConfig```. Rename the newly created _ScriptableObject_ to _TutorialConfig_. Set the name to _Tutorial_ and drag your prefabs into the controller fields. In your hierarchy navigate to ````[VRTK_SETUP] > [VRTK_Scripts] > ControllerConfigChooser```, expand the Configs section of the _ChooseController_ script and replace the config of _Steam VR_ + _HTC Vive_ with your _TutorialControllerConfig_. From now on, whenever you start your application - or to be more precise this scene, since controller configs are in scene not in project scope - your new custom controllers will be loaded.

The next step is to customize your controllers to see the difference. As mentioned before we simply change the appearance of the teleporter. In both of your custom controllers change the _VRTK_BezierPointerRenderer_ of the _TeleportPointer_ child object. On the bottom of the script you find _AppearanceSettings_ which you can replace with the prefabs in ```Assets > Extensions > hub-sdk > Extensions > VRTK > Assets > VRTK > Examples > ExampleResources > SharedResources > Prefabs > AnimatedBezierPointer```.

<p align="center">
  <img width="414px" height="89px" src="./Documentation/Images/Chapter13_CustomTeleport.png">
</p>

Run your application and teleport around to see the difference. To also make use of the new controllers in the _TutorialScene2_ change the setup accordingly.

**Solution:** Find the new controller prefabs, config and updated scene in _ChapterSolutions/Chapter-13_Customize-Controllers.unitypackage_.

## <a name="Chapter14"></a>**Chapter 14** Spectator

