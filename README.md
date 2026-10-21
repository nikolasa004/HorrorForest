# Horror Forest - A Terrain Experiment That Turned Into a Horror Prototype

<p align="center">
  <img src="docs/images/Screenshot%202026-10-20%20231919.png" alt="A winding path disappearing into a foggy forest and distant mountains" width="900">
</p>

*I wanted to learn how to build a landscape in Unity. Somehow, I ended up with an abandoned cabin, a creepy church, and a ghost.*

**[▶ Watch the gameplay showcase](https://youtu.be/G7pKmfRCs7c)** · **[⬇ Download the Windows prototype](https://github.com/nikolasa004/HorrorForest/releases/tag/v1.0.0)**

This is a small **Unity 3D horror prototype** I made around **2021**, when I was still very new to game development. It was one of my earliest projects - maybe my third, maybe a little later. I honestly don't remember the exact order.

It isn't a complete horror game, and it was never particularly close to becoming one. I made most of it in just a few days. But looking back, I'm surprised by how much atmosphere I managed to get out of a fairly simple environment, some lighting, and a handful of sounds.

## What is actually in the game?

You can explore a foggy forest with hills, dirt paths, grass, trees, and other vegetation. Hidden among them are two places I added to make the world a little more unsettling: **an abandoned cabin** and **an old church**.

There are a few small interactions and sound triggers, but no real objective, enemy AI, inventory, or complete story. Mostly, you walk around, explore, and see what happens when you approach certain places.

<p align="center">
  <img src="docs/images/Screenshot%202026-10-20%20233450.png" alt="Dense evergreen trees disappearing into the mist" width="440">
  <img src="docs/images/Screenshot%202026-10-20%20233632.png" alt="A forested hillside with trees and fog" width="440">
</p>

<p align="center">
  <img src="docs/images/Screenshot%202026-10-20%20234148.png" alt="Grass and small flowers covering the forest floor" width="800">
</p>

## Why I made another 3D project

After making my first Unity FPS prototype, I'd already come to the conclusion that creating a whole 3D game was probably more work than I wanted to take on. There was so much to model, texture, and put together, especially if I didn't want to rely entirely on other people's assets.

And yet, not long afterward, I found myself wanting to try it again.

I think it was something I saw in a game I was playing or watching at the time. I can't remember which game it was, but something about its world made me really curious about **creating landscapes in Unity**.

So I opened a new project and started experimenting with the **Terrain tools**: shaping hills, painting different surfaces, creating paths, adding trees, and filling the landscape with grass and plants. This wasn't a custom procedural world-generation algorithm. I was learning how to build and shape a natural environment using Unity's terrain editor.

At first, that was pretty much the entire idea. I just wanted to see what kind of world I could make.

## The horror part wasn't really the original plan

Once I had a forest, I started playing with the atmosphere. I made the lighting darker, added fog, experimented with wind and vegetation, and tried to make the trees feel dense and the landscape a little difficult to see through.

At some point, the obvious thought occurred to me: **this would make a pretty good setting for a horror game.**

I wasn't working from some carefully written horror story. I simply started looking through the assets available to me and picking things that fit the mood: a lonely wooden cabin, an abandoned church, blood, strange sounds, and other familiar horror details.

I liked the idea that you could be walking through an otherwise ordinary-looking forest and suddenly find something that didn't quite belong there.

### The cabin

<p align="center">
  <img src="docs/images/Screenshot%202026-10-20%20233357.png" alt="An abandoned wooden cabin surrounded by foggy trees" width="900">
</p>

<p align="center">
  <img src="docs/images/Screenshot%202026-10-20%20233416.png" alt="A dark interior with blood on the floor and furniture" width="900">
</p>

The cabin was one of my first attempts at making a location feel disturbing without giving the player much to do. An isolated building, a rocking chair outside, a dark interior, and signs that something unpleasant happened there - none of those things is especially complicated on its own.

But together, with the forest and the sound effects, they start to suggest a story even though I never actually wrote one.

### The church

<p align="center">
  <img src="docs/images/Screenshot%202026-10-20%20233714.png" alt="The old church tower rising out of the fog" width="440">
  <img src="docs/images/Screenshot%202026-10-20%20233730.png" alt="Looking through the church doorway toward a red-lit altar" width="440">
</p>

<p align="center">
  <img src="docs/images/Screenshot%202026-10-20%20233801.png" alt="Red lighting illuminating the church interior" width="900">
</p>

<p align="center">
  <img src="docs/images/Screenshot%202026-10-20%20233853.png" alt="A ghostly figure appearing inside the church" width="900">
</p>

I gave the church a completely different feeling from the forest. Outside, everything is grey, quiet, and covered in fog. Inside, there's this unnatural red light, and the space feels much more openly threatening.

There are simple triggers for things like the church bells and a frightening sound near the cabin. For the version I'm sharing now, I also added a very small encounter in the church: when you approach the altar, a ghostly figure appears behind you, near the entrance. It's a straightforward trigger that activates an existing object - nothing like a full enemy system - but it gives the location a moment of its own.

## The biggest thing I learned: sound matters

I think this was one of the first projects where I really understood **how important sound is to a game**, especially a horror game.

There's very little complicated programming here. You can move around, and a few triggers play sounds or activate something. The world itself is just a forest with two small locations to discover.

And yet, adding the sound of the wind, occasional noises in the background, church bells, and sudden effects around the buildings changes the experience completely.

I remember realizing that a relatively simple scene could suddenly feel much more convincing - and genuinely unsettling - when the sound was right. It was a useful lesson: atmosphere doesn't always come from adding more mechanics or making a game technically complicated.

Sometimes, what the player *hears* is doing a surprising amount of the work.

## A few days of experimenting - on a very weak computer

I made this prototype in a very short time. I don't think it was literally one day, but it was probably only a few days of playing around with terrain, assets, lighting, and audio.

One of the biggest problems was my computer. At the time, I was working with a machine that had **around 4 GB of RAM** and fairly modest graphics and processing power. Even working in the Unity Editor could be difficult once the forest became more detailed.

I started looking into optimization, but I quickly realized that I wasn't going to get the large, realistic 3D environment I wanted on that machine, at least not with the tools and knowledge I had then.

And there was the same problem that bothered me with my first FPS: most of the actual 3D models and textures came from other people's asset packs. I enjoyed arranging and shaping the world, but I still wanted to make games with more of my own visual work.

So I moved on to other experiments.

## Looking at it again, years later

It's funny to come back to this now and see how popular short indie horror games have become, especially games that people play or stream for a little while and then move on from.

A lot of them rely on relatively small environments, simple mechanics, sound cues, and an uncomfortable atmosphere - exactly the things I was playing with here. I'm not saying this prototype would have been a hit, or that finishing a good horror game would have been effortless. But looking at it now, I can imagine how it might have turned into a short, self-contained horror experience with a bit more work.

That isn't what I'm trying to do with this release, though.

I came back to the project mainly to **preserve it and show what I was experimenting with back then**, rather than to turn it into a brand-new game. Maybe I'll revisit something like this someday. For now, I'm happy to keep it as another small step in how I learned game development.

## Download and play

The playable Windows version is available in **[GitHub Releases](https://github.com/nikolasa004/HorrorForest/releases/tag/v1.0.0)**.

1. Download `HorrorForest.zip`.
2. Extract the entire ZIP archive, including the Unity data folder.
3. Run the game's `.exe` file.

This is an exploration and atmosphere prototype, not a game with a campaign or a proper ending.

**[Watch the gameplay video on YouTube →](https://youtu.be/G7pKmfRCs7c)**

### A note about the old project

The trees still sway in the wind when I run the project inside the Unity Editor, but that animation doesn't work in the recorded Windows build. Since this project is over five years old, I decided not to spend too much time rebuilding old shaders and other systems just to fix that detail. The grass and other vegetation still move, and the rest of the environment is shown as it is in the playable build.

### Source code and third-party assets

The repository includes my scripts, scenes, animations, and terrain data, but **it is not a fully self-contained Unity project**. The forest, buildings, vegetation, sounds, and other objects use various third-party assets that I've left out of the public source files rather than redistribute them as standalone content. Opening the project directly in Unity will therefore leave some references unresolved.

The source code is also old beginner code, with a few small fixes and additions made when I revisited the project for this showcase. I haven't tried to modernize the whole thing, because this repository is mainly meant to document an experiment from **2021**.

It started with a simple question - *what kind of landscape can I make in Unity?* - and turned into a little lesson in how a forest, some fog, and a few well-placed sounds can make even a tiny prototype feel like a horror game.
