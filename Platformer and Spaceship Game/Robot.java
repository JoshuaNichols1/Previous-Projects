import greenfoot.*;

public class Robot extends Players
{
    private int vSpeed = 0;
    private int acceleration = 1;
    private boolean jumping;
    private int jumpStrength = 16;
    private int speed = 4;
    int score = 0;
    int world = 0;
    private boolean hasfuel = false;
    private int direction = 1; // 1 = right and -1 = left

    /**
     * Act - do whatever the Player wants to do. This method is called whenever
     * the 'Act' or 'Run' button gets pressed in the environment.
     */
    public void act() 
    {
        checkKey();
        checkFall();
        platformAbove();
        checkRightWalls();
        checkLeftWalls();
        tryToTake();
    }   

    public void checkKey()
    {
        if ( Greenfoot.isKeyDown("a") )
        {
            moveLeft();
        }
        if ( Greenfoot.isKeyDown("d") )
        {
            moveRight();
        }
        if ( Greenfoot.isKeyDown("left") )
        {
            moveLeft();
        }
        if ( Greenfoot.isKeyDown("right") )
        {
            moveRight();
        }
        if(Greenfoot.isKeyDown("space") && jumping == false)
        {
            jump();
        }
        if(Greenfoot.isKeyDown("up") && jumping == false)
        {
            jump();
        }
    }

    public void moveRight()
    {
        setLocation(getX()+speed, getY());
    }

    public void moveLeft()
    {
        setLocation(getX()-speed, getY());
    }

    public boolean platformAbove()
    {
        int spriteHeight = getImage().getHeight();
        int yDistance = (int)(spriteHeight/-2);
        Actor ceiling = getOneObjectAtOffset(0, yDistance, Platform.class);
        if(ceiling != null)
        {
            vSpeed = 1;
            bopHead(ceiling);
            return true;
        }
        else
        {
            return false;
        }
    }

    public boolean checkRightWalls()
    {
        int spriteWidth = getImage().getWidth();
        int xDistance = (int)(spriteWidth/2);
        Actor rightWall = getOneObjectAtOffset(xDistance, 0, Platform.class);
        if(rightWall == null)
        {
            return false;
        }
        else
        {
            stopByRightWall(rightWall);
            return true;
        }
    }

    public void stopByRightWall(Actor rightWall)
    {
        int wallWidth = rightWall.getImage().getWidth();
        int newX = rightWall.getX() - (wallWidth + getImage().getWidth())/2;
        setLocation(newX - 5, getY());

    }

    public boolean checkLeftWalls()
    {
        int spriteWidth = getImage().getWidth();
        int xDistance = (int)(spriteWidth/-2);
        Actor leftWall = getOneObjectAtOffset(xDistance, 0, Platform.class);
        if(leftWall == null)
        {
            return false;
        }
        else
        {
            stopByLeftWall(leftWall);
            return true;
        }
    }

    public void stopByLeftWall(Actor leftWall)
    {
        int wallWidth = leftWall.getImage().getWidth();
        int newX = leftWall.getX() + (wallWidth + getImage().getWidth())/2;
        setLocation(newX + 5, getY());
    }

    public void bopHead(Actor ceiling)
    {
        int ceilingHeight = ceiling.getImage().getHeight();
        int newY = ceiling.getY() + (ceilingHeight + getImage().getHeight())/2;
        setLocation(getX(), newY);
    }

    public void fall()
    {
        setLocation(getX(), getY() + vSpeed);
        if(vSpeed <=9)
        {
            vSpeed = vSpeed + acceleration;
        }
        jumping = true;
    }

    public boolean onGround()
    {
        int spriteHeight = getImage().getHeight();
        int yDistance = (int)(spriteHeight/2) + 5;
        Actor ground = getOneObjectAtOffset(0, getImage().getHeight()/2, Platform.class);
        if(ground == null)
        {
            jumping = true;
            return false;
        }
        else
        {
            moveToGround(ground);
            return true;
        }
    }

    public void moveToGround(Actor ground)
    {
        int groundHeight = ground.getImage().getHeight();
        int newY = ground.getY() - (groundHeight + getImage().getHeight())/2;
        setLocation(getX(), newY);
        jumping = false;
    }

    public void checkFall()
    {
        if(onGround())
        {
            vSpeed = 0;
        }
        else
        {
            fall();
        }
    }

    public void jump()
    {
        vSpeed = vSpeed - jumpStrength;
        jumping = true;
        fall();
    }

    /**
     * Check whether we can see Martian. If we can, eat it.
     * 
     * @author Joshua Nichols
     */
    public void tryToTake()
    {
        if (canSee(Fuel.class))
        {
            take(Fuel.class);
            Level1 le1 = (Level1) getWorld();
            Bar bar = (Bar) le1.getObjects(Bar.class).get(0);
            int change = 154000;
            le1.bar.add(change);
        }
        if (canSee(Medical.class))
        {
            take(Medical.class);
            score = score + 10;
        }
        if (canSee(Ship.class))
        {
            take(Ship.class);
        }
    }

    /**
     * Return true if we can see an object of class 'clss' right where we are. 
     * False if there is no such object here.
     */
    public boolean canSee(Class clss)
    {
        Actor actor = getOneObjectAtOffset(0, 0, clss);
        return actor != null;        
    }

    /**
     * Try to grab an object of class 'clss'. This is only successful if there
     * is such an object where we currently are. Otherwise this method does
     * nothing.
     */
    public void take(Class clss)
    {
        Actor actor = getOneObjectAtOffset(0, 0, clss);
        if(actor != null) {
            getWorld().removeObject(actor);
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
