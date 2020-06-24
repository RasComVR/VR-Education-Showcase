<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/cover.gif" width="850" height="auto"/>
</p>

The mobile VR education showcase is a project which shows how smartphones using a Google cardboard VR viewer can be used in education. Google cardboard viewers use a smart phone to let the user see virtual environments with 3 degrees of freedom. These are rotational degrees of freedom which allow the user to look left / right, up / down, and tilt. A simple click based interface gives the user the ability to interact with the VR world. The Oculus Go, the Samsung Gear, the Google Daydream, and Google Cardboard are all examples of headsets with 3 degrees of freedom (3dof). More modern headsets like the Oculus Rift, Oculus Quest, HTC Vive, and Valve Index are headsets that have the 3 rotational degrees of freedom, but also have 3 translational degrees of freedom. Translational degrees of freedom allow the user to move forward / backward, left / right, and up / down. The combination gives these headsets a total of 6 degrees of freedom (6dof) and this makes the experience much more natural. However, smart phones are not able to track translational motion on the scale needed for a VR viewer, and this project focuses on the 3dof experience.

<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/Cardboard_Load.jpg" width="650" height="auto"/>
</p>

<p align="center">
    How a smartphone is used with a cardboard headset.
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/Screenshot_20170320-201939.png" width="850" height="auto"/>
</p>

<p align="center">
    The view on the smartphone before being placed in the headset.
</p>


This project is a virtual environment which the user can move around in, and interact with showcases that give examples of how VR can be used in education. The showcases describe the following:

1. Interactive 3D animations

2. Google Expeditions

3. A Virtual Art Gallery

4. 360 videos

5. Science Class Use Cases

 [Click here to see a YouTube video of the project.](https://www.youtube.com/embed/dDrKDwf1EFY)

<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/Screenshot_20170320-201922.png" width="850" height="auto"/>
</p>

 ## 3D Interactive Animations

Seeing 3D animations can be more intuitive to a human since we see and interact with the world in 3D. For this example, when the user clicks on the showcase arrow, a model of the Earth and the Moon will appear. The Moon orbits the Earth, and the Earth rotates. The animation can be changed when clicked again so that the Earth fades away and the Moon will be centered while rotating. Letting the user control how the animations change give them more agency to give a more interactive experience.

<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/earth_moon.gif" width="850" height="auto"/>
</p>

Apps can be made which allows for students to work through interactive animations at their own pace, and see larger objects in front of them which adds to the immersion.

## Google Expeditions

<div class=contentDiv id='contextDiv'>
  <img align="right" src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/Expeditions0.png" width='275' height='auto' ></img>

  <p align='left'> 
    Google launched an app which has guided tours that teachers can use in the classroom. The teacher has the app installed on a tablet or phone, and the students can all use their smartphones in cardboard viewers to experience the app. This showcase introduces how this can be used in the classroom to enable virtual fieldtrips. Every student will launch the app and connect to the teacher's tour. The teacher selects a virtual tour to take the class on. The class can visit the international space station, other countries and tourist locations, underwater environments, and even caves with ancient cave paintings. When the tour is launched, the class will go through a series of 360 photos.
    
  </p>
</div>

<br/><br/>

<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/Expeditions_VIEW.png" width="550" height="auto"/>
</p>

The teacher can see where in the 360 degree space the students are looking, and can guide them with visual prompts to look at specific objects of interest in the picture. The teacher can then advance the tour to the next image. One thing that makes this a good teaching tool is that the students are visually immersed. They do not see anything but what is in the tour. I used this app with 9th grade science students and 12th grade physics students. The students really enjoyed the experience and future virtual tours will only get better.

<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/Expeditions1.jpg" width="550" height="auto"/>
</p>

## A Virtual Art Gallery

Students can see pictures of famous art in text books and online. They can watch videos of what these works of art look like from different angles, but the lack of being in the same room as the pieces can make the experience flat.

Imagine how cool it would be to walk through a virtual art museum, being able to look at sculptures from different angles or to feel as though you were in the same physical space as these pieces.

<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/museum.gif" width="850" height="auto"/>
</p>

In the third showcase, a small sample of a virtual art museum can be explored. 


## 360 Videos in VR

360 videos are videos captured using a dual lens camera. Both cameras have a fisheye lens with a 180 degree field of view. The two videos are stitched together in post-processing and the result is a spherical video, showing everything around the camera. This is similar to how Google street-view images work. By being able to look in any direction when viewing these videos, the student gets to have control over their viewing experience.

This showcase looks at how these immersive videos can be used to generate empathy by putting the student in the shoes of someone else. 

<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/sc4.PNG" width="850" height="auto"/>
</p>

The image above is a simple 3 panel recreation from a video called Clouds over Sidra, which follows a 12 year old girl that is a Syrian refugee living in the Zaatari Refugee camp in Jordan. It was shown at Sundance and is very emotionally moving. Watching it in a VR headset adds an immersive experience that is not possible watching a video on a normal screen. Since the Unity game engine did not support adding 360 videos when this project was developed, I had to try to give the user a simple experience to show how one might be able to look around and see the environment.

360 videos can be watched on traditional screens and the user can pan around the video, but watching them in VR is a completely different experience. [Here is a link Clouds Over Sidra.](https://www.with.in/watch/clouds-over-sidra/)

<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/3panel.gif" width="850" height="auto"/>
</p>

These three images are from a series of videos which follow different people to give the user a taste of how different people in different cultures live. The leftmost image is from someone living in New York City. The middle image is from someone living in Jordan, and the rightmost image is from someone living in Kentucky. Each video was created in a series to give users insight into the lives of people living in other areas.

Being able to view experiences from a first person perspective gives a unique perspective and is useful for creating empathy to how others live.

## Science Class Use Cases

In any high school biology class you might notice one item which is common to every class. A plastic human skeleton. Every student will see pictures of the human skeleton in their textbooks, but being able to walk up to a life size version and see it close up, in 3D is very useful. This is one area that is explored in showcase 5. 

<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/sc5.gif" width="850" height="auto"/>
</p>

We can also look at Kyle the robot, and even be able to pull out circuit boards or other internal parts of the robot. Students learning how circuits work could have more control over how the circuits can be displayed in 3D. Likewise, layers of a biological specimen could be examined if they were rendered in 3D.

Lab classes can be expensive. College labs have very expensive equipment that students working in research might need to learn how to use. A company called Labster has created an app to virtually train students in virtual labs.

<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/labster-iso.png" width="850" height="auto"/>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/rasbot/Mobile_VR_Education_Showcase/master/images/labster1.PNG" width="850" height="auto"/>
</p>

Virtual science classes will give students a easier way to explore their learning and can save universities money to train students to use equipment that is difficult to obtain or costly to run.

These showcases are ways to explore the potential of VR in the classroom and are just a jumping off point to what sorts of VR experiences there are out there currently.

## Android Build

To access a build of the Mobile VR Education Showcase, use this link:

https://drive.google.com/file/d/1BgX6zO4yCjlYIO-qP0v6jYNhHPVTuP7O/view?usp=sharing

This is a build for Android smart phones only. To view the project, follow these steps.

* Download the apk file from the google drive link.

* Copy the apk file to your Android phone.

* Install the project by launching the apk file. You will most likely be asked if you want to install apps that are not from the Google play store. Click yes.

* Once the app has installed, launch it.

* You will probably be prompted to place your phone in a cardboard VR viewer. After doing this you should be able to interact with the project and explore it!
