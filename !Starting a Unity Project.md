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
* ProBuilder
* Test Framework
* TextMeshPro
  * add: a `UI\Text - TextMeshPro` item
  * select: `Import TMP Essentials`
* Timeline
* VS Code Editor
* VS Editor
* add: WebGL Publisher package to standard setup
  * discuss with team about publishing our projects to Unity Play

## Assets Folder
* add: `Animations` folder and placeholder
* add: `Editor` folder
  * add: `SaveOnRun.cs`
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
* add: `README.md`

## Asset Packages
* install: [spine](http://en.esotericsoftware.com/spine-unity-download) package
  * Assets\Import Package\Custom Package...
  * don't import the `Spine Examples` folder

## VS Code
* open: `SaveOnRun.cs` in VSCode to create `.vscode` folder entries
* add: debugger setup - `launch.json`

## Git
* close Unity - ensures all Unity changes are written to disk
* create git repo - use `main`
* add all files and commit everything locally
* create project at GitHub
* push the existing local repo to GitHub
* go to GitHub project Settings
  * go to Manage Access
    * invite: Johnathan (johnathanfeezy)
    * invite: Tim (timodamn)
* create a wiki for the project
  * each page should have a **Page Contents** section for the table of contents
  * create a Home page
    * describe the purpose of each section of the wiki
    * add a Project Schedule section
    * add a Project Structure And Staff section
    * add a Reference Games, Art, And Ideas section
  * create a General Notes page
  * create a Game Design Document page
    * add a Overall Vision of Game section
    * add a Definitions section
    * add a Design Pillars section
    * create an Audio Style page
    * create a Core Game Loop page
    * create a Marketing and Monetization page
    * create a Notable NPCs page
    * create a Replayability and Expandability page
    * create a Storyline page
    * create a Visual Style page
  * create a Game Technical Document page
    * add Project Meta Details section
    * create a UX Designs page
  * create a Mechanics page
    * create a list of Primary, Secondary, and Additional mechanics
    * create a page for each mechanic
  * create a Technical Notes page
    * create a Unity section
    * create a GitHub section
