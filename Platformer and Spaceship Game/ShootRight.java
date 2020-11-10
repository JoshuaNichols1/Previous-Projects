import greenfoot.*;

public class ShootRight extends ShootingManager
{
    private int shootingSpeed = 8;

    public ShootRight()
    {
        GreenfootImage myImage = getImage();
        int myNewHeight = (int)myImage.getHeight()*2;
        int myNewWidth = (int)myImage.getWidth()*2;
        myImage.scale(myNewWidth, myNewHeight);
    }

    public void act() 
    {
        setLocation(getX() + shootingSpeed, getY());
        killBadGuys();
    }    
}