import greenfoot.*;  // (World, Actor, GreenfootImage, Greenfoot and MouseInfo)

public class Level1 extends World
{
    public Bar bar = new Bar("","Fuel", 0, 770000);
    public Level1()
    {    
        super(800, 600, 1);
        GreenfootImage bg = getBackground();
        addObject(bar, 398,18);
        Score score = new Score();
        addObject(score,697,21);
        addObject(new Clock(true, true, 50, "Time left:"), 237, 32);
        prepare();
    }

    public void act()
    {
        if (getObjects(Ship.class).isEmpty())
        {
            if (getObjects(Medical.class).isEmpty())
            {
                if (getObjects(Fuel.class).isEmpty())
                {
                    nextLevel();
                }
                else
                {
                    Greenfoot.playSound("Lose Sound.mp3");
                    AlternateEnding AlternateEnding = new AlternateEnding();
                    addObject(AlternateEnding,398,300);
                    Greenfoot.stop();
                }
            }
            else
            {
                Greenfoot.playSound("Lose Sound.mp3");
                AlternateEnding AlternateEnding = new AlternateEnding();
                addObject(AlternateEnding,398,300);
                Greenfoot.stop();
            }
        }
    }

    public void nextLevel()
    {
        Greenfoot.setWorld(new Level2());
    }

    /**
     * Prepare the world for the start of the program.
     * That is: create the initial objects and add them to the world.
     */
    private void prepare()
    {
        Block block = new Block();
        addObject(block,419,587);
        Platform2 platform2 = new Platform2();
        addObject(platform2,65,110);
        Platform2 platform22 = new Platform2();
        addObject(platform22,604,146);
        Platform2 platform23 = new Platform2();
        addObject(platform23,744,145);
        Platform2 platform24 = new Platform2();
        addObject(platform24,450,247);
        Platform2 platform25 = new Platform2();
        addObject(platform25,660,313);
        platform25.setLocation(649,315);
        Platform2 platform26 = new Platform2();
        addObject(platform26,457,391);
        Platform2 platform27 = new Platform2();
        addObject(platform27,687,466);
        platform27.setLocation(663,464);
        platform27.setLocation(650,461);
        Platform2 platform28 = new Platform2();
        addObject(platform28,459,509);
        platform28.setLocation(460,507);
        platform27.setLocation(650,450);
        platform28.setLocation(500,499);
        Platform2 platform29 = new Platform2();
        addObject(platform29,186,344);
        platform29.setLocation(297,345);
        Platform2 platform210 = new Platform2();
        addObject(platform210,67,260);
        Platform2 platform211 = new Platform2();
        addObject(platform211,241,165);
        Robot robot = new Robot();
        addObject(robot,603,37);
        Ship ship = new Ship();
        addObject(ship,48,63);
        Wall wall = new Wall();
        addObject(wall,103,552);
        Wall wall2 = new Wall();
        addObject(wall2,76,232);
        wall2.setLocation(82,231);
        Medical medical = new Medical();
        addObject(medical,38,548);
        Medical medical2 = new Medical();
        addObject(medical2,720,414);
        Medical medical3 = new Medical();
        addObject(medical3,288,130);
        Medical medical4 = new Medical();
        addObject(medical4,755,543);
        Fuel fuel = new Fuel();
        addObject(fuel,762,543);
        Fuel fuel2 = new Fuel();
        addObject(fuel2,26,219);
        Fuel fuel3 = new Fuel();
        addObject(fuel3,737,276);
        Fuel fuel4 = new Fuel();
        addObject(fuel4,393,446);
        Fuel fuel5 = new Fuel();
        addObject(fuel5,514,208);
        Medical medical5 = new Medical();
        addObject(medical5,133,223);
        platform28.setLocation(464,488);
        platform29.setLocation(302,318);
        platform26.setLocation(451,376);
        medical4.setLocation(230,295);
        medical4.setLocation(235,273);
        platform28.setLocation(406,497);
        platform24.setLocation(443,222);
        platform29.setLocation(233,317);
        platform211.setLocation(193,157);
        platform25.setLocation(725,311);
        platform27.setLocation(663,450);
        platform28.setLocation(512,490);
        fuel4.setLocation(387,464);
        medical2.setLocation(726,416);
        fuel5.setLocation(508,180);
        platform28.setLocation(426,492);
        fuel4.setLocation(379,445);
        medical2.setLocation(728,384);
        fuel3.setLocation(736,258);
        medical3.setLocation(284,114);
        platform24.setLocation(443,213);
        platform211.setLocation(250,170);
        medical2.setLocation(698,420);
        medical3.setLocation(285,139);
        removeObject(platform26);
        Floater floater = new Floater();
        addObject(floater,451,375);
        Rules rules = new Rules();
        addObject(rules,398,300);
    }
}
