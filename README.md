# Studio Grub

**A VR Narrative Cooking Experience Designed to Alleviate Homesickness**

## Overview

Studio Grub is a virtual reality (VR) narrative-based cooking simulator designed to help college students — especially international students — cope with homesickness.

Research shows that up to 94% of students experience homesickness during college . Studio Grub addresses this emotional challenge by combining immersive VR interaction with culturally meaningful storytelling centered around food.

Rather than focusing on competition or high-speed mechanics, Studio Grub prioritizes emotional immersion, nostalgia, and comfort.

## Concept

Studio Grub blends:

* Immersive VR cooking interactions
* Narrative storytelling between player and a virtual “Mom”
* Culturally significant dishes
* A calming, therapeutic design philosophy

Players recreate family recipes while guided by voiceovers that share nostalgic memories tied to each dish.

### Featured Dishes

* Bengali Fish Curry
* Malaysian Nasi Goreng

Each dish represents the cultural backgrounds of our team and reinforces the project’s goal of reconnecting users with home through food.

## Gameplay Flow

1. Player reflects on missing home.
2. Prompt appears: “Call Mom?”
3. Player selects a dish from the menu.
4. Step-by-step guided cooking:

   * Chopping vegetables
   * Cracking eggs
   * Turning on the stove
   * Boiling and sizzling food
5. During cooking, nostalgic voiceovers play.
6. Completion triggers a heartfelt closing message.

We intentionally implemented a countdown timer (instead of a skill-based precision timer) to preserve a relaxing, narrative-driven experience .

## Technical Stack

Engine & Development:

* Unity (XR Toolkit)
* C#
* Blender (asset modification)

Hardware:

* Meta Quest VR headset & controllers

Assets:

* Kenney Food & Furniture Kits
* Unity Asset Store (smoke effects, UI assets)
* Custom-recorded voiceovers

## Key Technical Features

### Modular Scene Management

* Dynamic scene loading using Unity’s SceneManager
* Reusable scene loader script to reduce hard-coded transitions

### Configurable Timer System

* Supports count-up and countdown modes
* Frame-rate independent using Time.deltaTime
* Limit-based stopping logic
* Visual feedback (color change on completion)

### Interactive Object Systems

**Carrot Cutting Mechanic**

* Tag-based collision detection ("knife")
* Trigger-based object state switching
* Scene progression activation

**Egg Cracking Mechanic**

* Plate-triggered collision detection
* Dynamic object replacement (whole → cracked egg)
* UI activation upon successful interaction

### VR UI Implementation

* XR UI Canvas in World Space
* Graphic Raycaster + Tracked Device Raycaster
* EventSystem configuration for XR controller input

## Challenges Overcome

* Physics instability (Rigidbody constraint tuning)
* VR UI rendering issues
* XR interaction debugging
* Collider detection inconsistencies
* VR headset compatibility issues
* Full project recovery after accidental deletion

This project strengthened our skills in:

* Unity XR development
* VR interaction design
* Physics debugging
* Blender asset modification
* Collaborative problem-solving under time constraints


## Demo

[Game Demo Presentation](https://www.canva.com/design/DAGYXeJ8YI0/o_dD9_hyV-jT4RGY_XrgLQ/edit?utm_content=DAGYXeJ8YI0&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton)

## Future Improvements

* Expanded cultural recipe library
* More detailed cooking animations
* Additional interactive appliances
* Accessibility features (subtitles, voice commands)
* Difficulty customization
* Full start menu interface

## Team

Zaneeta Alam
Aashma Varma
Joyce Wan

Studio Grub demonstrates how immersive VR can combine technical precision with human-centered design to create emotionally meaningful interactive experiences.
