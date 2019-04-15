class Dot {
  PVector pos;
  PVector vel;
  PVector acc;
  Brain brain;

  boolean dead = false;
  boolean reachedfinalgoal=false;
  boolean reachedGoal1 = true;
  boolean reachedGoal2 = false;
  boolean reachedGoal3 = false;
  boolean reachedGoal4 = false;
 // boolean reachedGoal = false;
  boolean isBest = false;//true if this dot is the best dot from the previous generation
  PVector initial1=new PVector(400,500);
  PVector initial2=new PVector(680,500);
  float fitness = 0;
  

  Dot() {
    brain = new Brain(1000);//new brain with 1000 instructions

    //start the dots at the bottom of the window with a no velocity or acceleration
    pos = new PVector(width/2, height- 10);
    vel = new PVector(0, 0);
    acc = new PVector(0, 0);
  }


  //-----------------------------------------------------------------------------------------------------------------
  //draws the dot on the screen
  void show() {
    //if this dot is the best dot from the previous generation then draw it as a big green dot
    if (isBest) {
      fill(0, 255, 0);
      ellipse(pos.x, pos.y, 8, 8);
    } else {//all other dots are just smaller black dots
      fill(0);
      ellipse(pos.x, pos.y, 4, 4);
    }
  }

  //-----------------------------------------------------------------------------------------------------------------------
  //moves the dot according to the brains directions
  void move() {

    if (brain.directions.length > brain.step) {//if there are still directions left then set the acceleration as the next PVector in the direcitons array
      acc = brain.directions[brain.step];
      brain.step++;
    } else {//if at the end of the directions array then the dot is dead
      dead = true;
    }

    //apply the acceleration and move the dot
    vel.add(acc);
    vel.limit(5);//not too fast
    pos.add(vel);
  }

  //-------------------------------------------------------------------------------------------------------------------
  //calls the move function and check for collisions and stuff
  void update() {
    if (!dead && !reachedfinalgoal) {
      move();
        if (pos.x< 2|| pos.y<2 || pos.x>width-2 || pos.y>height -2) {//if near the edges of the window then kill it 
        dead = true;
      }
      else if (dist(pos.x, pos.y, finalgoal.x, finalgoal.y) < 5) 
      {//if reached goal
       
        reachedfinalgoal=true;
       }
       else if(dist(pos.x, pos.y, initial1.x, initial1.y)<25  )
       {
         reachedGoal1=false;
    
         
       }
         else if(dist(pos.x, pos.y, initial2.x, initial2.y)<25)
       {
         reachedGoal2=true;
         
         
       }
      else if (pos.x< 310 && pos.y < 800 && pos.x > 300 && pos.y > 450) 
      {//Left initial
        dead = true;
      }
      else if (pos.x< 510 && pos.y < 800 && pos.x > 500 && pos.y > 600)
      {//rright initial
        dead = true;
      }
      else if (pos.x< 750 && pos.y < 460 && pos.x > 300 && pos.y > 450)
      {//top initial
        dead = true;
      }
      else if (pos.x< 750 && pos.y < 610 && pos.x > 500 && pos.y > 600) 
      {//down initial
        dead = true;
      }//
       else if (pos.x< 660 && pos.y < 460 && pos.x > 650 && pos.y > 350) {//top left initial
        dead = true;
      }
      else if (pos.x< 760 && pos.y < 610 && pos.x > 750 && pos.y > 280) {//top right initial
        dead = true;
      }
    }
  }


  //--------------------------------------------------------------------------------------------------------------------------------------
  //calculates the fitness
  void calculateFitness() {
    if (reachedfinalgoal) {//if the dot reached the goal then the fitness is based on the amount of steps it took to get there
      fitness = 1.0/16.0 + 10000.0/(float)(brain.step * brain.step);
    } else {//if the dot didn't reach the goal then the fitness is based on how close it is to the goal---//over here the fitness should be made step by step
          if(reachedGoal1)
          {
             float distanceToGoal = dist(pos.x, pos.y, initial1.x, initial1.y);
             fitness = 1.0/(distanceToGoal * distanceToGoal);
          }
          else if(reachedGoal2)
          {
             float distanceToGoal = dist(pos.x, pos.y, initial2.x, initial2.y);
             fitness = 1.0/(distanceToGoal * distanceToGoal);
          }
          else
          {
            float distanceToGoal = dist(pos.x, pos.y, finalgoal.x, finalgoal.y);
              fitness = 1.0/(distanceToGoal * distanceToGoal);
          }
   }
  }

  //---------------------------------------------------------------------------------------------------------------------------------------
  //clone it 
  Dot gimmeBaby() {
    Dot baby = new Dot();
    baby.brain = brain.clone();//babies have the same brain as their parents
    return baby;
  }
}
