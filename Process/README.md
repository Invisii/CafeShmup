# Process Documentation

## 09.28.20 What's This? _What's This?_
 _(Idea Refinement & Analysis)_

Now that we have a basic idea of our shmup, we've been asked to consider a few questions to help guide our process and thinking:

**Which of Fullerton's Formal Elements are you working with?**
> Relative to a 'classic' shmup, I'll be primarily modifying the **resources** and **objectives**. The core mechanic I'm adding is a meter to measure the consistency of the player's movements + the accuracy of their shots (the more you fire, the more the meter increases). This is an abstract resource, but since it's also tied to a more literal resouce: the coffee that the player is carrying. This coffee is a resource in itself because the player can spill the coffee which reduces the number of points they can score (per coffee).

**What kinds of puzzles or player challenges might you include?**
> Since the meter requires the player to focus on their immediate actions and reactions, I imagine adding any classic sort of puzzle would only overcomplicate the game. I imagine it would be better to simply add obstacles to the space they can move in, as that will provide greater challenge to the player without asking them to focus on too many things at once. If I include the mechanic of spilled coffee creating a slick surface, there's great opportunities for level design where players can only walk through one path to reach their objectives. There's a careful balance though with this, as it will be easy to make this sort of dynamic feel punishing, especially if the player generates the spills that impede their progress.

**What are the basic rules for your game?**
> The player controls a character that can move any direction from a top down 2D view. The player carries a cup of coffee that they have to deliver to customers sitting in their cafe. As they do so, upset customers will berate them by firing laser projectiles into the cafe. The player has a laser pistol they can use to fend off the upset customers (one shot will kill them). If the player moves too inconsistently, fires their pistol, or get hits by one of the upset customer, their spill meter will rise. The spill meter constantly empties, but if it ever reaches a certain point, the player will spill a bit of coffee on the ground. If this happens too many times before the player can drop off the coffee, the player loses a life. When the player delivers the coffee, they are awarded points based on how little coffee they spilled. The game functions in rounds where the player must deliver a certain number of coffees to complete a round. When the player runs out of lives, the game is over.


## 09.25.20 Started From the Bottom 
_(Brainstorming)_

When we first brainstormed ideas for a Shmup, we came up with three of them. I really liked the second one I came up with, and I feel like it has a lot of potential to be expanded upon:

>   A bullet hell where you are a barista in a cafe and you must bring coffee to people without taking too much damage.

I imagine this as a sort of multidirectional shooter where you are berated by multiple enemies that keep appearing rather than a single boss (though a mechaKaren might be a fun boss battle/elite enemy).

I also imagine the core mechanic as tied to the consistency of your actions almost like a rhythm game mechanic. I imagine this in the form a meter that slowly empties over time but fills in bursts when you suddenly change direction or shoot too rapidly. Going over the limit of the meter causes you to spill some of the drink you are carrying thereby reducing the points from its delivery.

Spilling the drink provides an interesting opportunity for another mechanic: a temporary slippery surface on the floor that might cause you to move erratically if you pass back over it.

I really like this idea especially since it focuses heavily on the avoidance aspect of shmup games. However, given the mechanics I would like to implement, I imagine this will lighter on the bullet hell aspect since the consistency of your movements hold such importance.
