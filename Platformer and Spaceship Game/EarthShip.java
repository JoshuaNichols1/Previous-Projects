import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Rocket here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class EarthShip extends Players
{
    private int shootingCounter = 20; // Delay shooting
    private int score = 0;
    private int points = 0;
    private boolean hasBoost = false;
    /**
     * This method is the act method
     * 
     * @author Joshua Nichols
     */
    public void act()
    {
        checkKey();
        tryToEat();
        shooting();
        isHit();
        isHit2();
        shootingCounter --;
        // tryToEatBoost();
    }

    public void checkKey()
    {
        if ( Greenfoot.isKeyDown("left") )
        {
            move(-5);
        }
        if ( Greenfoot.isKeyDown("right") )
        {
            move(5);
        }
        if (Greenfoot.isKeyDown("up"))
        {
            setLocation(getX(), getY()-4);
        }
        if (Greenfoot.isKeyDown("down"))
        {
            setLocation(getX(), getY()+4);
        }
        if ( Greenfoot.isKeyDown("space") )
        {
            shooting();
        }
    }

    public boolean shooting()
    {
        if(Greenfoot.isKeyDown("space") && shootingCounter <= 0)
        {
            Greenfoot.playSound("Explosion Sound.mp3");
            getWorld().addObject(new ShootRight(), getX(), getY());
            shootingCounter = 20;
            return true;
        }
        return false;
    }

    public void isHit() 
    {
        if (isTouching(Asteroid.class)) {
            removeTouching(Asteroid.class);
            HeartRemove();
        }
    }

    public void HeartRemove()
    {
        if(getWorld().getObjects(Heart1.class).isEmpty())
        {
            if(getWorld().getObjects(Heart2.class).isEmpty())
            {
                if(getWorld().getObjects(Heart3.class).isEmpty())
                {
                    gameOver();
                }
                else
                {
                    getWorld().removeObjects(getWorld().getObjects(Heart3.class));
                }
            }
            else
            {
                getWorld().removeObjects(getWorld().getObjects(Heart2.class));
            }
        }
        else
        {
            getWorld().removeObjects(getWorld().getObjects(Heart1.class));
        }
    }

    public void isHit2() 
    {
        if (isTouching(Satalite.class)) {
            removeTouching(Satalite.class);
            if(getWorld().getObjects(Boost.class).isEmpty())
            {
                tryToEatBoost();
            }
            else
            {
                HeartRemove();
            }
        }
    }

    public void gameOver() 
    {
        GameOver GameOver = new GameOver();
        getWorld().addObject(GameOver,398,300);
        Greenfoot.playSound("Lose Sound.mp3");
        Greenfoot.stop();
    }

    public void tryToEat()
    {
        if (canSee(Fuel2.class))
        {
            take(Fuel2.class);
            Level2 le2 = (Level2) getWorld();
            Bar bar = (Bar) le2.getObjects(Bar.class).get(0);
            int change = 128334;
            le2.bar.add(change);
        }
        if(canSee(Boost.class))
        {
            take(Boost.class);
            Heart4 heart4 = new Heart4();
            getWorld().addObject(heart4,665,26);
            hasBoost = true;
            tryToEatBoost();
        }
    }

    public void YouWin()
    {
        YouWin YouWin = new YouWin();
        getWorld().addObject(YouWin,398,300);
        Greenfoot.playSound("Win Sound.mp3");
        Greenfoot.stop();
    }

    /**
     * This code eats the coins and adds to the counter. If the boost has 
     *  been picked up then the coin value will double.
     */
    public void tryToEatBoost()
    {              
        if(getWorld().getObjects(Boost.class).isEmpty())
        {
            if(getWorld().getObjects(Heart1.class).isEmpty())
            {
                if(getWorld().getObjects(Heart2.class).isEmpty())
                {
                    if(getWorld().getObjects(Heart3.class).isEmpty())
                    {
                        if(getWorld().getObjects(Heart4.class).isEmpty())
                        {
                            gameOver();
                        }
                        else
                        {
                            getWorld().removeObjects(getWorld().getObjects(Heart4.class));
                        }
                    }
                    else
                    {
                        getWorld().removeObjects(getWorld().getObjects(Heart3.class));
                    }
                }
                else
                {
                    getWorld().removeObjects(getWorld().getObjects(Heart2.class));
                }
            }
            else
            {
                getWorld().removeObjects(getWorld().getObjects(Heart1.class));
            }
        }
    }

    public void Cheat()
    {
        if ( Greenfoot.isKeyDown("0") )
        {
            if ( Greenfoot.isKeyDown("f1") )
            {
                hasBoost = true;
            }
        }
    }

    /**
     * Holds the score variable to be called by the Scores class for display.
     */
    public int getScore()
    {    
        return score;
    }  
}
