# Shattered Sky

## Installation

### Git

First of all you need to download this repository. Note that you need to have [Git LFS](https://git-lfs.com) installed also. I assume you already have some git experience and won't focus on any details. Just clone repo wherever you want and continue to the next step.

### Unity

You need to install the Unity Editor `2022.3.21f1`.
Simplest way is to download it from Unity Hub from [unity's website](https://unity.com/download).

After you have installed Unity Hub, you need to open it and sign in.

![sign_in](.gitlab/assets/sign_in.png)

The process is streamlined so I won't go into details here.
Next in installs tab you need to install Unity. Open Unity Hub and select `Install` section.

![install_section](.gitlab/assets/install_section.png)

Then click install editor and click install near `2022.3.21f1`.

![select_editor](.gitlab/assets/select_editor.png)

Uncheck all the boxes, you wan't need them.

![empty_boxes](.gitlab/assets/empty_boxes.png)

Wait for download to finish and continue to the next step.

### Open project

I highly suggest you to read through [Unity overview](https://docs.unity3d.com/Manual/UnityOverview.html) to get familiar with Unity. You can ask me questions anytime, if you need help.

First you need to add project to Unity Hub.

![open_project](.gitlab/assets/open_project.png)

Then it will appear at Projects tab. Click on it to start.

Next find your [project window](https://docs.unity3d.com/Manual/ProjectView.html). There in the `Scenes` folder you will find EntryPoint scene. Double click on it to open.

![entry_point](.gitlab/assets/entry_point.png)

And last click on `Play` button to start game. Game should start.

![play](.gitlab/assets/play.png)

## Developing

### Branching

Let's keep it simple.

- `master` branch is for release versions of a game. Only working versions that will go to pages.
- `dev` branch is for unstable versions of a game. Work in progress, main state of a development.
- `feature/<feature_name>` branch is for new features. It's not required, you can ignore it and commit your work into `dev` branch. But it's highly recommended for complex features.

### Commit messages

It's not required, but it's good practice to have a clear names for the commits. Better to start your commits with tags:

- `add:` for new additions to script or images.
- `del:` for removing deprecated script or images.
- `upd:` for updating script or images.
- `fix:` for bug fixes.

### Limitations

**Do not** move/rename files outside of Unity. It's required for now to avoid conflicts inside Unity.
