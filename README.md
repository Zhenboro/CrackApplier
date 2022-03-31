# CrackApplier
Aplicador de parches

## Using it
first, this is partly translated with google translate.

### CrackApplier
1. Open the CrackApplier project.
2. In the CrackApplier project, go to MyProject and then go to Resources.
3. Expand and select Files. Then add an existing file.
4. Select the patched file
5. Once added, rename the resource to "CrackFile"
6. In the Resources folder (not in MyProject>Resources) you should still see the original name of the file.
7. Compile the project.
8. Once done, it's time to start the CrackApplier IDE

### CrackApplier IDE
1. Start CrackApplier
2. Enter the required data.
    -Program name: It is the name of the program itself. What program is the patch aimed at?
    - Crack name: The name of the crack. As you, as a hacker, you have put the file patched / cracked.
    - Cracked file: The name of the file that has been patched/cracked.
    - Crack type: The type of crack. Example: License, Password, etc.
    - Install path: Where is the file that will be replaced by the patch/crack.

* If you check 'Inject?'
    + an extra step will be necessary, since the resource will be injected and will not be read from MyProyect (embedded).
      Before step 7 (final) you must select the binary (file) of the crack (the patch). When you select it, click Open and the IDE will inject that binary into the           final CrackApplier.
      >With this step, you don't need to add the resource to the project. Basically, you can skip compiling the CrackApplier project with your patch. You must skip the        'Using it>CrackApplier' section.
3. Now click on "Create CrackApplier"
4. A window will start asking you to select the binary you have compiled. Select CrackApplier.exe from the Debug folder
5. Then another one will start, this file that asks you to save is the binary that will be the one that you can distribute. Choose a path and name to save it.
6. Done, now you can distribute the binary.
