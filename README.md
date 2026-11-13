# Flappy Bird - C# WinForms

A complete, feature-rich clone of the classic Flappy Bird game built from scratch using **C# Windows Forms** (.NET). This project demonstrates object-oriented programming, custom physics integration, and advanced GDI+ graphics handling within a standard WinForms environment.

##  Key Technical Features

* **Custom Physics & Collision:** Hand-coded gravity mechanics (`birdVelocity`), jump triggers, and precise rectangular collision detection between the bird and moving obstacles.
* **GDI+ Mathematical Rotation:** Implemented dynamic sprite rotation (`RotesteImage`) based on the bird's vertical velocity to simulate realistic flight angles and nose-dives.
* **Memory Management:** Integrated strict resource cleanup using the `Dispose` method to prevent GDI memory leaks during rapid frame rendering and obstacle respawning.
* **State Machine & Animation:** Custom logic for game states (Hover ping-pong mechanics, Play, Pause/Resume, Game Over) and sprite animation.
* **Persistent High Scores:** Game progress and all-time high scores are permanently saved and managed using `Properties.Settings`.
* **Dynamic Difficulty:** Progressive scaling of obstacle speed and gap sizes to increase difficulty as the score gets higher.

##  How to Run

1. Clone or download the repository.
2. Open the `.csproj` file in **Visual Studio**.
3. Press `F5` (or click Start) to build and run the game. No extra dependencies are required.
