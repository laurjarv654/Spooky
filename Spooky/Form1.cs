/// created by : Max Jarvis
/// date       : 10/23/19
/// description: A basic text adventure game engine
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Spooky
{
    public partial class Form1 : Form
    {
        double scene = 0;
        bool doll = false;
        bool drawing = false;
        bool knife = false;

        Random randGen = new Random();

        public Form1()
        {

            InitializeComponent();
            SoundPlayer livingRoom = new SoundPlayer(Properties.Resources.livingroomSound2);
            livingRoom.Play();
            //scene 0 setup
            pictureBox1.BackgroundImage = Properties.Resources.living_room;
            mainStory.Text = "You wake up on the floor of an unfamiliar living room. No lights are on and it seems as though no one has lived here in a long time. There are three closed doors. Which one do you choose?";
            option1.Text = "Door one. (A)";
            option2.Text = "Door two. (D)";
            option3.Text = "Door three. (W)";

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int percent = randGen.Next(1, 101);

            SoundPlayer livingRoom = new SoundPlayer(Properties.Resources.livingroomSound2);
            SoundPlayer upstairs = new SoundPlayer(Properties.Resources.foyerSound2);
            SoundPlayer ending = new SoundPlayer(Properties.Resources.endingSound);

            //option1 (Red on Flowchart)
            if (e.KeyCode == Keys.A)
            {
                //door 1
                
                if (scene == 0) { scene = 1; }
                //laughter
                else if (scene == 1) { scene = 2; }
                //back to beginning
                else if (scene == 2) { scene = 99; }
                //investigating in the front hall
                else if (scene == 3) { scene = 2; }
                //arriving upstairs
                else if (scene == 4) { scene = 5; }
                //master bedroom
                else if (scene == 5 && percent < 65) { scene = 7; }
                else if (scene == 5 && percent > 65) { scene = 8; }
                //door three
                else if (scene == 6) { scene = 6.1; }
                else if (scene == 6.1) { scene = 6.2; }
                else if (scene == 6.2) { scene = 21; }
                //falling asleep in the master bedroom
                else if (scene == 7) { scene = 22; }
                //hearing something from the closet
                else if (scene == 8) { scene = 6; }
                //bathroom
                else if (scene == 9) { scene = 10; }
                //in the foyer with the key
                else if (scene == 10) { scene = 10.1; }
                else if (scene == 10.1) { scene = 10.2; }
                else if (scene==10.2) { scene = 21; }
                //entering the kitchen
                else if (scene == 11) { scene = 12; }
                //kid's drawing
                else if (scene == 12) { scene = 13; }
                //knife
                else if (scene == 13) { scene = 1; }
                //children's bodies
                else if (scene == 14 && knife == true) { scene = 18; }
                else if (scene == 14 && knife == false) { scene = 19; }
                //hearing their story
                else if (scene == 15 && doll == true && drawing == true ) { scene = 16; }
                else if (scene == 15 && doll == true && drawing == false) { scene = 16.1; }
                else if (scene == 15 && doll == false && drawing == true) { scene = 16.2; }
                else if (scene == 15 && doll == false && drawing == false) { scene = 17; }
                //true ending
                else if (scene == 16) { scene = 23; }
                else if (scene == 16.1) { scene = 23; }
                else if (scene == 16.2) { scene = 23; }
                //failed ending
                else if (scene == 17&&knife==true) { scene = 18; }
                else if (scene == 17 && knife == false) { scene = 19; }
                //failed ending with knife
                else if (scene == 18) { scene = 21; }
                //failed ending without knife
                else if (scene == 19) { scene = 21; }
                ////play again
                else if (scene == 21||scene == 22||scene==23) { scene = 99; }
                //opening screen
                else if (scene == 99) { scene = 1; }
            }

            //option 2 (blue on flowchart)
            if (e.KeyCode == Keys.D)
            {
                //door 2
                if (scene == 0) { scene = 11; }
                //going upstairs
                else if (scene == 1) { scene = 4; }
                //going upstairs after finding doll
                else if (scene == 3) { scene = 4; }
                //upstairs, door 2 (bathroom)
                else if (scene == 4) { scene = 9; }
                //bedroom, check the closet
                else if (scene == 5) { scene = 14; }
                //from bathroom to bedroom
                else if (scene == 9) { scene = 5; }
                // from kitchen to foyer
                else if (scene == 11) { scene = 1; }
                else if (scene == 12) { scene = 1; }
                //listening to the children
                else if (scene == 14) { scene = 15; }
                //exiting game
                else if (scene == 21) { this.Close(); }
                else if (scene == 22) { this.Close(); }
                else if (scene == 23) { this.Close(); }
                //door 2
                else if (scene == 99) { scene = 11; }

            }

            // option 3 (green)
            if (e.KeyCode == Keys.W)
            {
                //door 3
                if (scene == 0) { scene = 6; }
                //look around in foyer
                else if (scene == 1) { scene = 3; }
                else if (scene == 99) { scene = 6; }
            }

            switch (scene)
            {
                case 99:
                    pictureBox1.Image = Properties.Resources.living_room;
                    ending.Stop();
                    livingRoom.Play();
                    mainStory.Text = "You wake up on the floor of an unfamiliar living room. No lights are on and it seems as though no one has lived here in a long time. There are three closed doors. Which one do you choose?";
                    option1.Text = "Door one.(A)";
                    option2.Text = "Door two.(D)";
                    option3.Text = "Door three.(W)";
                    break;

                case 1:
                    livingRoom.Play();
                    pictureBox1.Image = Properties.Resources.foyer;
                    mainStory.Text = "You enter the front foyer of the house. You could try to leave through the front door, go up the stairs or investigate a litte.";
                    option1.Text = "The door.(A)";
                    option2.Text = "The stairs.(D)";
                    option3.Text = "Look around.(W)";
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.black;
                    livingRoom.Stop();
                    mainStory.Text = "Haha you thought you could just leave?";
                    option1.Text = "Yes..?(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 3:
                    mainStory.Text = "You decide to investigate a litte. You find a raggedy, old doll and decide to carry it with you. Now what?";
                    option1.Text = "Try the door.(A)";
                    option2.Text = "Go upstairs.(D)";
                    option3.Text = "";
                    doll = true;
                    break;

                case 4:
                    livingRoom.Stop();
                    upstairs.Play();
                    pictureBox1.Image = Properties.Resources.hallway;
                    mainStory.Text = "You are now upstairs. Everything is super dusty... In the hallway are two doors. Which will you choose?";
                    option1.Text = "Door 1.(A)";
                    option2.Text = "Door 2.(D)";
                    option3.Text = "";
                    break;

                case 5:
                    upstairs.Play();
                    pictureBox1.Image = Properties.Resources.bedroom3;
                    mainStory.Text = "You enter the first door to find the master bedroom. Something comes over you and you start to feel really sleepy. Lay in the bed or try to look around?";
                    option1.Text = "Lay in the bed.(A)";
                    option2.Text = "Search the closet.(D)";
                    option3.Text = "";
                    break;

                case 6:
                    livingRoom.Stop();
                    ending.Play();
                    pictureBox1.Image = Properties.Resources.child;
                    mainStory.Text = "You hear odd noises coming from door three. You open to find the monster hiding inside!  You feel yourself pass out an it's inky black substance surrounds you. You hear a faint voice.";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 6.1:
                    mainStory.Text = "It's...";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 6.2:
                    mainStory.Text = "It's...  apologizing?";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;


                case 7:
                    mainStory.Text = "You lay down and feel sleep come over you. Right before you're about to lose consciousness, you feel someone pull the covers up onto you.";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 8:
                    mainStory.Text = "You lay down and hear a sound come from the closet. With a feeling of unease you decide to go and check it out.";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 9:
                    upstairs.Play();
                    pictureBox1.Image = Properties.Resources.bathrrom;
                    mainStory.Text = "You open the door and enter what's left of the bathroom. You found a key on the counter! It must be for the front door. Go try it or check out the other room?";
                    option1.Text = "Try the key.(A)";
                    option2.Text = "Check out the second room.(D)";
                    option3.Text = "";
                    break;

                case 10:
                    upstairs.Stop();
                    livingRoom.Play();
                    pictureBox1.Image = Properties.Resources.foyer;
                    mainStory.Text = "You're back down in the foyer and unlock the door.";
                    option1.Text = "Coninue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 10.1:
                    livingRoom.Stop();
                    pictureBox1.Image = Properties.Resources.black;
                    mainStory.Text = "Nice try, but that's not going to work here.";
                    option1.Text = "Coninue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 10.2:
                    ending.Play();
                    pictureBox1.Image = Properties.Resources.black;
                    mainStory.Text = "You open the door. All you can see is inky blackness. It seems sentient. It traps you.";
                    option1.Text = "Coninue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 11:
                    livingRoom.Play();
                    pictureBox1.Image = Properties.Resources.kitchen;
                    mainStory.Text = "You enter the kitchen. Would you like to move on to the foyer or have a look around?";
                    option1.Text = "Look around.(A)";
                    option2.Text = "Head to the foyer.(D)";
                    option3.Text = "";
                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.kitchendrawing;
                    mainStory.Text = "You look inside the fridge. Looking for something to munch on, all you find is some moldy cheese. As you go to close the fridge, you notice an old drawing of a family. It looks like it's been drawn by a kid. Something compelled you to keep it so you slipped it into you pocket. Would you like to look inside some drawers or continue to the foyer?";
                    option1.Text = "Keep looking around.(A)";
                    option2.Text = "Move on.(D)";
                    option3.Text = "";
                    drawing = true;
                    break;

                case 13:
                    pictureBox1.Image = Properties.Resources.kitchenknife;
                    mainStory.Text = "You find a butcher knife in one of the drawers. You turn it in your hands. Keeping a hold on to it, just in case, you move on to the foyer.";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    knife = true;
                    break;

                case 14:
                    ending.Play();
                    pictureBox1.Image = Properties.Resources.closet;
                    mainStory.Text = "You enter and see a pile of bodies. The stench makes your eyes water. You hear faint voices whisper in your ear.";
                    option1.Text = "Get out of there.(A)";
                    option2.Text = "Listen to the voices.(D)";
                    option3.Text = "";
                    break;

                case 15:
                    mainStory.Text = "The voices belong to the fallen children. They whisper in you ear and tell you of their stories and the wretched monster that resides in this house. To defeat it, you must face it with evidence of the past children.";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 16:

                    mainStory.Text = "You pull out both the doll and old drawing and turn around to see a child staring at you. They had ink pouring from their eyes and mouth. Upon noticing the doll and drawing, it began to shriek and back away. Instinctively, you held out the objects. The black ink-like substance starting to disappear. You start to feel dizzy and pass out.";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 16.1:
                    pictureBox1.Image = Properties.Resources.child;
                    mainStory.Text = "You pull out the doll that you had found and turn around to see a child staring at you. They had ink pouring from their eyes and mouth. Upon noticing the doll, it began to shriek and back away. Instinctively, you held out the object. The black ink-like substance starting to disappear. You start to feel dizzy and pass out.";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 16.2:
                    pictureBox1.Image = Properties.Resources.child;
                    mainStory.Text = "You pull out the old drawing and turn around to see a child staring at you. They had ink pouring from their eyes and mouth. Upon noticing the drawing, it began to shriek and back away. Instinctively, you held out the object. The black ink-like substance starting to disappear. You start to feel dizzy and pass out.";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 17:
                    ending.Play();
                    mainStory.Text = "You search your pockets and realize that you perhaps should have spent more time searching around. A black inky subtances surrounds you and you become one with the darkness.";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 18:
                    ending.Play();
                    pictureBox1.Image = Properties.Resources.black;
                    mainStory.Text = "The voices fade. You slash at the darkness with the knife you found but it's no good. You become one with the darkness.";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 19:
                    ending.Play();
                    pictureBox1.Image = Properties.Resources.black;
                    mainStory.Text = "The voices fade and you become one with the darkness.";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 20:
                    ending.Play();
                    pictureBox1.Image = Properties.Resources.child;
                    mainStory.Text = "It's locked! You turn around to come face to face with a small child with black eyes. An inky black substance surrounds you and you become one with the darkness.";
                    option1.Text = "Continue.(A)";
                    option2.Text = "";
                    option3.Text = "";
                    break;

                case 21:
                    ending.Play();
                    pictureBox1.Image = Properties.Resources.black;
                    mainStory.Text = "YOU DIED. Play again?";
                    option1.Text = "Yes.(A)";
                    option2.Text = "No.(D)";
                    option3.Text = "";
                    break;

                case 22:
                    ending.Stop();
                    pictureBox1.Image = Properties.Resources.realbedroom;
                    mainStory.Text = "You wake up in your own bed. Turning on the light, you see a small black stain on your shirt. You escaped, but just barely.  Play again?";
                    option1.Text = "Yes.(A)";
                    option2.Text = "No.(D)";
                    option3.Text = ""; 
                    break;

                case 23:
                    ending.Stop();
                    pictureBox1.Image = Properties.Resources.realbedroom;
                    mainStory.Text = "You wake up at home and look into the mirror. You see that there's a bit of black ink on your shirt but it started to fade away. It seems as though you successfully defeated the monster and set all of the children's souls free.  Play again?";
                    option1.Text = "Yes.(A)";
                    option2.Text = "No.(D)";
                    option3.Text = ""; 
                    break;


            }
        }
    }
}
