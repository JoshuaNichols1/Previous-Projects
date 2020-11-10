import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Level2 here.
 * 
 * @author (your name)
 * @version (a version number or a date)
 */
public class Level2 extends World
{
    public Bar bar = new Bar("", "Fuel", 0, 770000);
    // public HealthBar healthbar = new HealthBar("", "Lives", 2, 3);

    public Level2()
    {    
        super(800, 600, 1);
        EarthShip earthship = new EarthShip();
        addObject(earthship,50,315);
        addObject(bar, 398,18);
        // addObject(healthbar, 200,18);
        prepare();
    }

    public void act()
    {
        if(Greenfoot.getRandomNumber(150) < 5) 
        {
            addObject(new Asteroid(),  this.getWidth()-1, Greenfoot.getRandomNumber(this.getHeight()));   
        }
        if(Greenfoot.getRandomNumber(150) < 5) 
        {
            addObject(new Fuel2(),  this.getWidth()-1, Greenfoot.getRandomNumber(this.getHeight()));   
        }
        if(Greenfoot.getRandomNumber(150) < 1) 
        {
            addObject(new Satalite(),  this.getWidth()-1, Greenfoot.getRandomNumber(this.getHeight()));
        }
        if (bar.getValue() == bar.getMaximumValue())
        {
            YouWin();
        }
        if(getObjects(Heart4.class).isEmpty())
        {
            if(getObjects(Boost.class).isEmpty())
            {
                int x = Greenfoot.getRandomNumber(getHeight());
                int y = (563);
                addObject(new Boost(), x, y);
            }
        }
        else
        {
            removeObjects(getObjects(Boost.class));
        }
    }

    public void YouWin()
    {
        YouWin YouWin = new YouWin();
        addObject(YouWin,398,300);
        Greenfoot.playSound("Win Sound.mp3");
        Greenfoot.stop();
    }

    public void GameOver()
    {
        GameOver GameOver = new GameOver();
        addObject(GameOver,398,300);
        Greenfoot.playSound("Lose Sound.mp3");
        Greenfoot.stop();
    }

    /**
     * Prepare the world for the start of the program.
     * That is: create the initial objects and add them to the world.
     */
    private void prepare()
    {
        Heart1 heart1 = new Heart1();
        addObject(heart1,545,26);
        Heart2 heart2 = new Heart2();
        addObject(heart2,585,26);
        Heart3 heart3 = new Heart3();
        addObject(heart3,625,26);
        Boost boost = new Boost();
        addObject(boost,783,315);
    }
}
