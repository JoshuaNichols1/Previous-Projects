import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Score here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Score extends Hud
{
    int score = 0;
    
    public void act()   
    {    
        int score = ((Robot) getWorld().getObjects(Robot.class).get(0)).getScore();
        setImage(new GreenfootImage("Score: " + score +" ", 20, Color.WHITE, null));
    }   
}
