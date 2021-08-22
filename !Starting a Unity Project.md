# Starting a Unity Project
## Prerequisite
* check to see if anything needs updating
* is there an update to Unity
* did we create additional `Editor` scripts
* did we update the `.gitignore`
* did we update the `.editorconfig`
* is there an update to `Microsoft.Unity.Analyzers.dll` - v1.11.0.0
* is there an update to [spine](http://en.esotericsoftware.com/spine-unity-download) - v3.8-2021-04-12

## New Project
* create new unity project
  * make sure Unity Hub uses the correct version of Unity
* add define `ENABLE_LOGS`
  * Go to Edit > Project Settings... > Player > Scripting Define Symbols

## Packages
reconfigure the packages to have only the following
* 2D Sprite
* Cinemachine
* ProBuilder
* Test Framework
* TextMeshPro
  * add: a `UI\Text - TextMeshPro` item
  * select: `Import TMP Essentials`
* Timeline
* VS Code Editor
* VS Editor
* WebGL Publisher

## Assets Folder
* add: `Animations` folder and placeholder
* add: `Editor` folder
* add: `Gizmos` folder and placeholder
* add: `Materials` folder and placeholder
* add: `Prefabs` folder and placeholder
* add: `Scripts` folder and placeholder
* add: `ScriptTemplates` and custom CS script templates
* add: `ScritableObjects` folder and placeholder
* add: `Sounds` folder and placeholder
* add: `Sprites` folder and placeholder
* add: `Textures` folder and placeholder

## Top Level Items
* add: `Builds` folder
* add: `nuget` folder
  * add: `Microsoft.Unity.Analyzers.dll`
* add: `.editorconfig`
* add: `.gitignore`
* add: `omnisharp.json`
* add: `readme.md`

## Asset Packages
* install: [spine](http://en.esotericsoftware.com/spine-unity-download) package
  * Assets\Import Package\Custom Package...
  * don't import the `Spine Examples` folder

## VS Code
* open: `SaveOnRun.cs` in VSCode to create `.vscode` folder entries
* add: debugger setup - `launch.json`
  * if file is copied then update the "Unity Editor" path

## Git
* close Unity - ensures all Unity changes are written to disk

In the project's local folder run the following commands.  This assumes [GitHub CLI](https://cli.github.com/) is installed.

```
git init
git add .
git commit -am "Initial commit"
gh repo create --private
git push --set-upstream origin main
```

* go to GitHub project Settings
  * go to Manage Access
    * invite team members
      * invite: Tim (timodamn)
