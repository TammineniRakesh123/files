Population test;
PVector finalgoal  = new PVector(400, 10);


void setup() {
  size(800, 800); //size of the window
  frameRate(100);//increase this to make the dots go faster
  test = new Population(2000);//create a new population with 1000 members
}


void draw() { 
  background(255);

  //draw goal
  fill(255, 255, 0);
  rect(finalgoal.x, finalgoal.y, 20, 20);

  //draw obstacle(s)
  fill(0, 50, 0);

 rect(300, 450, 10, 350);
   rect(500, 600, 10,200);
   //left middle
    rect(300, 450, 350, 10);
   rect(500, 600, 250, 10);
   //middle top
     rect(650, 350, 10, 110);
     rect(750, 280, 10, 330);


  if (test.allDotsDead()) {
    //genetic algorithm
    test.calculateFitness();
    test.naturalSelection();
    test.mutateDemBabies();
  } else {
    //if any of the dots are still alive then update and then show them

    test.update();
    test.show();
  }
}
