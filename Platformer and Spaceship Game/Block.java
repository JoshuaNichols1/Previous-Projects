import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

/**
 * Write a description of class Block here.
 * 
 * @author (your name) 
 * @version (a version number or a date)
 */
public class Block extends Platform
{
    public Block()
    {
        GreenfootImage myImage = getImage();
        int myNewHeight = (int)myImage.getHeight()*1;
        int myNewWidth = (int)myImage.getWidth()*30;
        myImage.scale(myNewWidth, myNewHeight);
    }    
}
