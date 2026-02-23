# PG Hierarchy Folder Creator


![Unity](https://img.shields.io/badge/Unity-2022.3%2B-black)

A lightweight Unity Editor utility designed to keep your scene Hierarchy clean and organized. It provides locked "Folder" objects and visual "Separators" to easily structure your GameObjects without messing up their transforms.

## Features

* **Hierarchy Folders:** Creates special GameObjects that act as structural folders. Their `Transform` components are automatically locked to `Vector3.zero` for position, `Quaternion.identity` for rotation, and `Vector3.one` for scale. This prevents accidental offsets for any nested child objects.
* **Custom Hierarchy Icons:** Automatically displays a standard folder icon next to your folder objects directly in the Unity Hierarchy window for quick visual identification.
* **Hierarchy Separators:** Generates distinct separator objects (e.g., `-----------Name --------------------------`) to visually divide your hierarchy into logical sections.
* **Easy Access:** Quickly create folders and separators via the `GameObject -> PG -> Sort` menu.

## Installation (Unity Package Manager)

You can easily install this package directly through the Unity Package Manager using the repository URL.

1. Open Unity and navigate to `Window` -> `Package Manager`.
2. Click the `+` button in the top left corner of the Package Manager window.
3. Select **"Add package from git URL..."**.
4. Paste the following link and click **Add**:

```text
https://github.com/7Lucia7Lokidottir7/PG-Hierarchy-Folder-Creator.git?path=/Hierarchy%20Folder%20Creator/Assets/PG%20Hierarchy%20Folder%20Creator
