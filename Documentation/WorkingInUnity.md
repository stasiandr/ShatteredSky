# Working inside Unity (for content makers)

First of all let's talk about working folders structure. 
When you open Unity in Project Window you will look something like this:

```tree
Assets
├── Plugins     // Folder for external plugins
├── Resources   // Main working folder for content creators
├── Scenes      // Unity scenes
├── Scripts     // Code
├── Settings    // Unity settings
└── Tests       // Ha-ha tests on a pet project
```

You need Scenes folder only once to open entry point scene. Then you will only work with Resources folder. 
Let's take a look at the structure of Resources folder:

```tree
Resources
├── Backgrounds  // Backgound images
├── Characters   // Character images
└── Plot         // Yarn scripts
```

### Path

In Resources folder you will place and edit all assets (images, yarns, sounds, etc.) that you need. 
Every asset can be addressed with it's path without extension. For example if you place `image.png` in `Backgrounds` folder,
later on you may reference this image with `Backgrounds/image`.

## Yarn extensions

For yarn entry point you must have only one node named `Start` in any yarn file in the project. 
For further information about yarn, please visit [Yarn documentation](https://docs.yarnspinner.dev/beginners-guide/welcome).  

### Commands

You can use [commands](https://docs.yarnspinner.dev/getting-started/writing-in-yarn/commands) to make some actions in editor. 
On top of builtin commands we've added several more.

#### <<background "%path%">>

This command will load background from the specified %path%.

#### <<character %index% %path%>>

This command will load character from the specified %path%. %index% is the index of character on screen. 
For now only 0 or 1 is supported. If you want to unload character you can set %path% argument to empty.

Examples:

```
<<character 0 "Characters/Stas">> // will load character from "Resources/Characters/Stas.jpeg" ad place it to the left
<<character 1 "">>                // will clear rigth character
```

 

