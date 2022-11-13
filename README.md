AIHR Logic Assignment - Solar System
==

In this solution the model has been kept relatively simple by not modeling the separate planet categories—or indeed the individual planets themselves—as their own types, but rather by using a single planet type to represent the various instances of planets within a planetary system. Further distinction between the types of planets, such as terrestrial, gas or ice giant, dwarf, is made through the `PlanetType` property.

Because there are no separate types to represent the individual planets, it is also not possible to comply with the assignment directions to declare marker interfaces to identify life sustaining or terraformable planetary bodies. These marker interfaces would have had to be implemented by specific planet types, such as Venus, Earth, Mars etc. So instead, interfaces have been defined that declare an operation, implemented as a property, through which the question of whether a planetary body is life sustaining or terraformable is answered.

A graphical overview of the model is provided as a UML class diagram below.

![UML class diagram](https://github.com/jimatas/Aihr.SolarSystem/blob/master/SolarSystem.png?raw=true)

The data used to populate the solar system with its celestial bodies was sourced from both the Wikipedia and NASA websites.
