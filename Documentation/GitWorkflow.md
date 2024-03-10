# Git Workflow

## Branching

Let's keep it simple.

- `master` branch is for release versions of a game. Only working versions that will go to pages.
- `dev` branch is for unstable versions of a game. Work in progress, main state of a development.
- `feature/<feature_name>` branch is for new features. It's not required, you can ignore it and commit your work into `dev` branch. But it's highly recommended for complex features.

## Commit messages

It's not required, but it's good practice to have a clear names for the commits. Better to start your commits with tags:

- `add:` for new additions to script or images.
- `del:` for removing deprecated script or images.
- `upd:` for updating script or images.
- `fix:` for bug fixes.

## Limitations

**Do not** move/rename files outside of Unity. It's required for now to avoid conflicts inside Unity.
