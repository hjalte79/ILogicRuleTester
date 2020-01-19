# ILogicRuleTester
I write a lot of iLogic rules. Mostly examples for people on the [autodesk Inventor customization forum](https://forums.autodesk.com/t5/inventor-customization/bd-p/120). The editor that you find in Inventor is not that great when you are used to work in Visual Studio. That is why i created a Visual Studio project that i can use to write i logic code. 

## Project goal
My goal is to make a project that helps me create iLogic code that i can copy directly into Inventor. 

## setup.
This project was created for Inventor 2018. If you are using another version then you need to change the dll references. 

## How to use.
Start writing your code in the module "ILogicStartModule" in the sub "Main()"

**At this moment only the following iLogic helper properties/functions are available:**
 - ThisApplication
 - ThisDoc
 
 I would like to add also functions for Parameter() but i did not manage that yet. If you want to help on this projetct then send a pull request.

**Other functions that i use regularly:**

| Function  | Parameters  | returns | description |
| --------- | ----------- | ------- | ----------- |
|showtInventorObjectType| obj As Object | Nothing | Shows messagebox with the inventor object type|
