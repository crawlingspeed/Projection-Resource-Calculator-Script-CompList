case "Armor blocks":
	if (lightArmorOnly)
	{ steelplateCount = steelplateCount + 1; }
	else
	{
		steelplateCount = steelplateCount + 5;
		metalgridCount = metalgridCount + 2;
	}

	break;

case "Heavy Angled Armor Corner":
case "Heavy Angled Armor Slope":
case "Heavy Armor Slope":
case "Heavy Armor Corner 2x1x1 Base":
case "Heavy Armor Corner 2x1x1 Base Smooth":
	steelplateCount = steelplateCount + 3;
	metalgridCount = metalgridCount + 1;
	break;

case "Heavy Armor Block":
	steelplateCount = steelplateCount + 5;
	metalgridCount = metalgridCount + 2;
	break;

case "Heavy Armor Corner":
case "Heavy Armor Corner 2x1x1 Tip":
case "Heavy Armor Corner 2x1x1 Tip Smooth":
case "Heavy Armor Slope 2x1x1 Tip":
case "Heavy Armor Slope 2x1x1 Tip Smooth":
	steelplateCount = steelplateCount + 2;
	metalgridCount = metalgridCount + 1;
	break;

case "Heavy Armor Inv. Corner":
case "Heavy Armor Round Corner":
case "Heavy Armor Round Slope":
case "Rounded Heavy Armor Corner":
case "Rounded Heavy Armor Slope":
case "Heavy Armor Slope 2x1x1 Base":
	steelplateCount = steelplateCount + 4;
	metalgridCount = metalgridCount + 1;
	break;

case "Heavy Armor Inv. Corner 2x1x1 Base":
case "Heavy Armor Inv. Corner 2x1x1 Base Smooth":
case "Heavy Armor Round Inv Corner":
case "Heavy Armor Slope 2x1x1 Base Smooth":
	steelplateCount = steelplateCount + 5;
	metalgridCount = metalgridCount + 1;
	break;



case "Light Angled Armor Corner":
case "Light Angled Armor Slope":
case "Light Armor Block":
case "Light Armor Corner":
case "Light Armor Corner 2x1x1 Base":
case "Light Armor Corner 2x1x1 Base Smooth":
case "Light Armor Corner 2x1x1 Tip":
case "Light Armor Corner 2x1x1 Tip Smooth":
case "Light Armor Inverted Corner":
case "Light Armor Slope":
case "Light Inv Corner 2x1x1 Base":
case "Light Inv Corner 2x1x1 Base Smooth":
case "Light Inv Corner 2x1x1 Tip":
case "Light Inv Corner 2x1x1 Tip Smooth":
case "Light Round Armor Corner":
case "Light Round Armor Inv Corner":
case "Light Round Armor Slope":
case "Light Rounded Armor Corner":
case "Light Rounded Armor Slope":
case "Light Slope 2x1x1 Base":
case "Light Slope 2x1x1 Base Smooth":
case "Light Slope 2x1x1 Tip":
case "Light Slope 2x1x1 Tip Smooth":
	steelplateCount = steelplateCount + 1;
	break;
	//start
	//check piston and rotor if correct
case "Advanced Rotor": steelplateCount = steelplateCount + 3; constructioncomponentCount = constructioncomponentCount + 5; smallsteeltubeCount = smallsteeltubeCount + 1; motorCount = motorCount + 1; computerCount = computerCount + 1; steelplateCount = steelplateCount + 2; break;
case "Air Vent": steelplateCount = steelplateCount + 5; constructioncomponentCount = constructioncomponentCount + 10; motorCount = motorCount + 2; computerCount = computerCount + 5; steelplateCount = steelplateCount + 3; break;
case "Antenna": steelplateCount = steelplateCount + 1; smallsteeltubeCount = smallsteeltubeCount + 1; constructioncomponentCount = constructioncomponentCount + 1; computerCount = computerCount + 1; radiocomponentCount = radiocomponentCount + 4; constructioncomponentCount = constructioncomponentCount + 1; break;
case "Artificial Mass": steelplateCount = steelplateCount + 1; superconductorconduitCount = superconductorconduitCount + 2; constructioncomponentCount = constructioncomponentCount + 2; computerCount = computerCount + 2; gravgencomponentCount = gravgencomponentCount + 1; steelplateCount = steelplateCount + 2; break;
case "Atmospheric Thrusters": steelplateCount = steelplateCount + 2; constructioncomponentCount = constructioncomponentCount + 20; largesteeltubeCount = largesteeltubeCount + 1; metalgridCount = metalgridCount + 1; motorCount = motorCount + 18; constructioncomponentCount = constructioncomponentCount + 2; steelplateCount = steelplateCount + 1; break;
case "Battery": steelplateCount = steelplateCount + 5; constructioncomponentCount = constructioncomponentCount + 2; powercellCount = powercellCount + 20; computerCount = computerCount + 2; constructioncomponentCount = constructioncomponentCount + 3; steelplateCount = steelplateCount + 20; break;
case "Beacon": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 1; smallsteeltubeCount = smallsteeltubeCount + 1; computerCount = computerCount + 1; radiocomponentCount = radiocomponentCount + 4; steelplateCount = steelplateCount + 1; break;
case "Blast door corner inverted": steelplateCount = steelplateCount + 3; steelplateCount = steelplateCount + 2; break;
case "Blast door corner": steelplateCount = steelplateCount + 3; steelplateCount = steelplateCount + 2; break;
case "Blast door edge": steelplateCount = steelplateCount + 3; steelplateCount = steelplateCount + 2; break;
case "Blast doors": steelplateCount = steelplateCount + 3; steelplateCount = steelplateCount + 2; break;
case "Button Panel": interiorplateCount = interiorplateCount + 2; constructioncomponentCount = constructioncomponentCount + 1; computerCount = computerCount + 1; constructioncomponentCount = constructioncomponentCount + 1; break;
case "Camera": steelplateCount = steelplateCount + 1; computerCount = computerCount + 3; steelplateCount = steelplateCount + 1; break;
case "Cockpit": steelplateCount = steelplateCount + 5; constructioncomponentCount = constructioncomponentCount + 10; motorCount = motorCount + 1; displayCount = displayCount + 5; computerCount = computerCount + 15; steelplateCount = steelplateCount + 5; bulletproofglassCount = bulletproofglassCount + 30; break;
case "Collector": steelplateCount = steelplateCount + 25; constructioncomponentCount = constructioncomponentCount + 35; smallsteeltubeCount = smallsteeltubeCount + 12; motorCount = motorCount + 8; displayCount = displayCount + 2; computerCount = computerCount + 8; steelplateCount = steelplateCount + 10; break;
case "Connector": steelplateCount = steelplateCount + 15; constructioncomponentCount = constructioncomponentCount + 12; smallsteeltubeCount = smallsteeltubeCount + 6; motorCount = motorCount + 6; computerCount = computerCount + 6; steelplateCount = steelplateCount + 6; break;
case "Control Panel": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 1; computerCount = computerCount + 1; displayCount = displayCount + 1; break;
case "Control Seat": interiorplateCount = interiorplateCount + 10; constructioncomponentCount = constructioncomponentCount + 15; motorCount = motorCount + 1; computerCount = computerCount + 15; displayCount = displayCount + 2; constructioncomponentCount = constructioncomponentCount + 5; interiorplateCount = interiorplateCount + 10; break;
case "Conveyor Frame": interiorplateCount = interiorplateCount + 4; constructioncomponentCount = constructioncomponentCount + 12; smallsteeltubeCount = smallsteeltubeCount + 5; motorCount = motorCount + 2; interiorplateCount = interiorplateCount + 1; break;
case "Conveyor Junction": interiorplateCount = interiorplateCount + 20; constructioncomponentCount = constructioncomponentCount + 30; smallsteeltubeCount = smallsteeltubeCount + 25; motorCount = motorCount + 2; constructioncomponentCount = constructioncomponentCount + 15; interiorplateCount = interiorplateCount + 5; break;
case "Conveyor Sorter": interiorplateCount = interiorplateCount + 4; constructioncomponentCount = constructioncomponentCount + 10; smallsteeltubeCount = smallsteeltubeCount + 5; computerCount = computerCount + 5; motorCount = motorCount + 2; constructioncomponentCount = constructioncomponentCount + 2; interiorplateCount = interiorplateCount + 1; break;
case "Corner LCD Bottom": constructioncomponentCount = constructioncomponentCount + 3; computerCount = computerCount + 2; displayCount = displayCount + 1; break;
case "Corner LCD Flat Bottom": constructioncomponentCount = constructioncomponentCount + 3; computerCount = computerCount + 2; displayCount = displayCount + 1; break;
case "Corner LCD Flat Top": constructioncomponentCount = constructioncomponentCount + 3; computerCount = computerCount + 2; displayCount = displayCount + 1; break;
case "Corner LCD Top": constructioncomponentCount = constructioncomponentCount + 3; computerCount = computerCount + 2; displayCount = displayCount + 1; break;
case "Corner Light - Double": constructioncomponentCount = constructioncomponentCount + 4; break;
case "Corner Light": constructioncomponentCount = constructioncomponentCount + 2; break;
case "Cryo Chamber": interiorplateCount = interiorplateCount + 15; constructioncomponentCount = constructioncomponentCount + 10; motorCount = motorCount + 4; displayCount = displayCount + 4; medcomponentCount = medcomponentCount + 3; computerCount = computerCount + 15; interiorplateCount = interiorplateCount + 5; bulletproofglassCount = bulletproofglassCount + 5; break;
case "Curved Conveyor Tube": interiorplateCount = interiorplateCount + 2; constructioncomponentCount = constructioncomponentCount + 20; smallsteeltubeCount = smallsteeltubeCount + 10; motorCount = motorCount + 6; interiorplateCount = interiorplateCount + 5; break;
case "Dead Astronaut": steelplateCount = steelplateCount + 13; superconductorconduitCount = superconductorconduitCount + 13; break;
case "Decoy": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 1; computerCount = computerCount + 1; radiocomponentCount = radiocomponentCount + 1; smallsteeltubeCount = smallsteeltubeCount + 2; steelplateCount = steelplateCount + 1; break;
case "Drill": steelplateCount = steelplateCount + 20; constructioncomponentCount = constructioncomponentCount + 30; largesteeltubeCount = largesteeltubeCount + 4; motorCount = motorCount + 1; computerCount = computerCount + 1; steelplateCount = steelplateCount + 12; break;
case "Ejector": steelplateCount = steelplateCount + 5; constructioncomponentCount = constructioncomponentCount + 4; smallsteeltubeCount = smallsteeltubeCount + 2; motorCount = motorCount + 1; computerCount = computerCount + 4; steelplateCount = steelplateCount + 2; break;
case "Fighter Cockpit": constructioncomponentCount = constructioncomponentCount + 20; motorCount = motorCount + 1; steelplateCount = steelplateCount + 10; metalgridCount = metalgridCount + 10; interiorplateCount = interiorplateCount + 15; displayCount = displayCount + 4; computerCount = computerCount + 20; bulletproofglassCount = bulletproofglassCount + 40; steelplateCount = steelplateCount + 10; break;
case "Gatling Gun": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 1; metalgridCount = metalgridCount + 2; smallsteeltubeCount = smallsteeltubeCount + 6; motorCount = motorCount + 1; computerCount = computerCount + 1; steelplateCount = steelplateCount + 3; break;
case "Gatling Turret": steelplateCount = steelplateCount + 5; constructioncomponentCount = constructioncomponentCount + 25; metalgridCount = metalgridCount + 5; smallsteeltubeCount = smallsteeltubeCount + 6; motorCount = motorCount + 4; computerCount = computerCount + 10; constructioncomponentCount = constructioncomponentCount + 5; steelplateCount = steelplateCount + 5; break;
case "Grinder": steelplateCount = steelplateCount + 10; constructioncomponentCount = constructioncomponentCount + 15; smallsteeltubeCount = smallsteeltubeCount + 4; motorCount = motorCount + 4; computerCount = computerCount + 2; constructioncomponentCount = constructioncomponentCount + 2; steelplateCount = steelplateCount + 2; break;
case "Gyroscope": steelplateCount = steelplateCount + 15; constructioncomponentCount = constructioncomponentCount + 5; largesteeltubeCount = largesteeltubeCount + 1; motorCount = motorCount + 2; computerCount = computerCount + 3; steelplateCount = steelplateCount + 10; break;
case "Hydrogen Engine": steelplateCount = steelplateCount + 20; constructioncomponentCount = constructioncomponentCount + 18; largesteeltubeCount = largesteeltubeCount + 4; smallsteeltubeCount = smallsteeltubeCount + 6; motorCount = motorCount + 4; computerCount = computerCount + 1; powercellCount = powercellCount + 1; constructioncomponentCount = constructioncomponentCount + 2; steelplateCount = steelplateCount + 10; break;
case "Hydrogen Tank": steelplateCount = steelplateCount + 60; largesteeltubeCount = largesteeltubeCount + 40; smallsteeltubeCount = smallsteeltubeCount + 60; computerCount = computerCount + 8; constructioncomponentCount = constructioncomponentCount + 40; steelplateCount = steelplateCount + 20; break;
case "Hydrogen Thrusters": steelplateCount = steelplateCount + 2; constructioncomponentCount = constructioncomponentCount + 10; metalgridCount = metalgridCount + 4; largesteeltubeCount = largesteeltubeCount + 2; constructioncomponentCount = constructioncomponentCount + 5; steelplateCount = steelplateCount + 5; break;
case "Industrial Cockpit": steelplateCount = steelplateCount + 10; constructioncomponentCount = constructioncomponentCount + 20; metalgridCount = metalgridCount + 10; motorCount = motorCount + 2; displayCount = displayCount + 6; computerCount = computerCount + 20; bulletproofglassCount = bulletproofglassCount + 60; smallsteeltubeCount = smallsteeltubeCount + 10; break;
case "Interior Light": constructioncomponentCount = constructioncomponentCount + 2; break;
case "Ion Thrusters": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 1; largesteeltubeCount = largesteeltubeCount + 1; thrustercomponentCount = thrustercomponentCount + 1; constructioncomponentCount = constructioncomponentCount + 1; steelplateCount = steelplateCount + 1; break;
case "Ladder": interiorplateCount = interiorplateCount + 10; constructioncomponentCount = constructioncomponentCount + 10; smallsteeltubeCount = smallsteeltubeCount + 10; constructioncomponentCount = constructioncomponentCount + 10; break;
case "Landing Gear": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 5; motorCount = motorCount + 1; steelplateCount = steelplateCount + 1; break;
case "Large Atmospheric Thruster": steelplateCount = steelplateCount + 10; constructioncomponentCount = constructioncomponentCount + 20; largesteeltubeCount = largesteeltubeCount + 4; metalgridCount = metalgridCount + 8; motorCount = motorCount + 90; constructioncomponentCount = constructioncomponentCount + 10; steelplateCount = steelplateCount + 10; break;
case "Large Cargo Container": interiorplateCount = interiorplateCount + 55; constructioncomponentCount = constructioncomponentCount + 25; computerCount = computerCount + 6; motorCount = motorCount + 8; displayCount = displayCount + 1; interiorplateCount = interiorplateCount + 20; break;
case "Large Hydrogen Thruster": steelplateCount = steelplateCount + 20; constructioncomponentCount = constructioncomponentCount + 20; metalgridCount = metalgridCount + 22; largesteeltubeCount = largesteeltubeCount + 10; constructioncomponentCount = constructioncomponentCount + 10; steelplateCount = steelplateCount + 10; break;
case "Large Ion Thruster": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 1; largesteeltubeCount = largesteeltubeCount + 5; thrustercomponentCount = thrustercomponentCount + 12; constructioncomponentCount = constructioncomponentCount + 1; steelplateCount = steelplateCount + 4; break;
case "Large Reactor": steelplateCount = steelplateCount + 40; constructioncomponentCount = constructioncomponentCount + 9; metalgridCount = metalgridCount + 9; largesteeltubeCount = largesteeltubeCount + 3; reactorcomponentCount = reactorcomponentCount + 95; motorCount = motorCount + 5; computerCount = computerCount + 25; steelplateCount = steelplateCount + 20; break;
case "Laser Antenna": steelplateCount = steelplateCount + 6; smallsteeltubeCount = smallsteeltubeCount + 10; constructioncomponentCount = constructioncomponentCount + 10; motorCount = motorCount + 5; radiocomponentCount = radiocomponentCount + 5; superconductorconduitCount = superconductorconduitCount + 10; computerCount = computerCount + 30; bulletproofglassCount = bulletproofglassCount + 2; steelplateCount = steelplateCount + 4; break;
case "LCD Panel": interiorplateCount = interiorplateCount + 1; constructioncomponentCount = constructioncomponentCount + 4; computerCount = computerCount + 4; displayCount = displayCount + 3; bulletproofglassCount = bulletproofglassCount + 2; break;
case "Medium Cargo Container": interiorplateCount = interiorplateCount + 20; constructioncomponentCount = constructioncomponentCount + 10; computerCount = computerCount + 4; motorCount = motorCount + 4; displayCount = displayCount + 1; interiorplateCount = interiorplateCount + 10; break;
case "Medium Conveyor Tube": interiorplateCount = interiorplateCount + 8; constructioncomponentCount = constructioncomponentCount + 20; smallsteeltubeCount = smallsteeltubeCount + 10; motorCount = motorCount + 6; interiorplateCount = interiorplateCount + 2; break;
case "Merge Block": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 5; motorCount = motorCount + 1; smallsteeltubeCount = smallsteeltubeCount + 2; computerCount = computerCount + 1; steelplateCount = steelplateCount + 3; break;
case "Missile Turret": steelplateCount = steelplateCount + 5; constructioncomponentCount = constructioncomponentCount + 30; metalgridCount = metalgridCount + 2; largesteeltubeCount = largesteeltubeCount + 2; motorCount = motorCount + 8; computerCount = computerCount + 12; constructioncomponentCount = constructioncomponentCount + 10; steelplateCount = steelplateCount + 5; break;
case "O2/H2 Generator": steelplateCount = steelplateCount + 6; constructioncomponentCount = constructioncomponentCount + 8; largesteeltubeCount = largesteeltubeCount + 2; motorCount = motorCount + 1; computerCount = computerCount + 3; steelplateCount = steelplateCount + 2; break;
case "Ore Detector": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 2; motorCount = motorCount + 1; computerCount = computerCount + 1; detectorcomponentCount = detectorcomponentCount + 1; steelplateCount = steelplateCount + 2; break;
case "Oxygen Tank": steelplateCount = steelplateCount + 10; largesteeltubeCount = largesteeltubeCount + 8; smallsteeltubeCount = smallsteeltubeCount + 10; computerCount = computerCount + 8; constructioncomponentCount = constructioncomponentCount + 10; steelplateCount = steelplateCount + 6; break;
case "Parachute Hatch": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 2; smallsteeltubeCount = smallsteeltubeCount + 1; motorCount = motorCount + 1; computerCount = computerCount + 1; steelplateCount = steelplateCount + 1; break;
case "Passenger Seat": interiorplateCount = interiorplateCount + 10; constructioncomponentCount = constructioncomponentCount + 20; interiorplateCount = interiorplateCount + 10; break;
case "Piston": steelplateCount = steelplateCount + 2; constructioncomponentCount = constructioncomponentCount + 4; smallsteeltubeCount = smallsteeltubeCount + 4; motorCount = motorCount + 2; computerCount = computerCount + 1; steelplateCount = steelplateCount + 2; break;
	//case "Piston": steelplateCount = steelplateCount + 2; constructioncomponentCount = constructioncomponentCount + 4; smallsteeltubeCount = smallsteeltubeCount + 4; motorCount = motorCount + 2; computerCount = computerCount + 1; steelplateCount = steelplateCount + 2; break;
case "Programmable block": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 2; largesteeltubeCount = largesteeltubeCount + 2; motorCount = motorCount + 1; displayCount = displayCount + 1; computerCount = computerCount + 2; steelplateCount = steelplateCount + 1; break;
case "Projector": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 2; largesteeltubeCount = largesteeltubeCount + 2; motorCount = motorCount + 1; computerCount = computerCount + 2; steelplateCount = steelplateCount + 1; break;
case "Reloadable Rocket Launcher": smallsteeltubeCount = smallsteeltubeCount + 50; interiorplateCount = interiorplateCount + 40; constructioncomponentCount = constructioncomponentCount + 24; largesteeltubeCount = largesteeltubeCount + 8; metalgridCount = metalgridCount + 10; motorCount = motorCount + 4; computerCount = computerCount + 2; steelplateCount = steelplateCount + 8; interiorplateCount = interiorplateCount + 10; break;
case "Remote Control": interiorplateCount = interiorplateCount + 1; constructioncomponentCount = constructioncomponentCount + 1; motorCount = motorCount + 1; computerCount = computerCount + 1; interiorplateCount = interiorplateCount + 1; break;
case "Rocket Launcher": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 2; metalgridCount = metalgridCount + 1; largesteeltubeCount = largesteeltubeCount + 4; motorCount = motorCount + 1; computerCount = computerCount + 1; steelplateCount = steelplateCount + 3; break;
case "Rotating Light": constructioncomponentCount = constructioncomponentCount + 2; motorCount = motorCount + 1; constructioncomponentCount = constructioncomponentCount + 1; break;
case "Rotor Part": steelplateCount = steelplateCount + 12; smallsteeltubeCount = smallsteeltubeCount + 6; break;
	//case "Rotor Part": steelplateCount = steelplateCount + 30; largesteeltubeCount = largesteeltubeCount + 10; break;
case "Rotor": steelplateCount = steelplateCount + 3; constructioncomponentCount = constructioncomponentCount + 5; smallsteeltubeCount = smallsteeltubeCount + 1; motorCount = motorCount + 1; computerCount = computerCount + 1; steelplateCount = steelplateCount + 2; break;
case "Sensor": interiorplateCount = interiorplateCount + 5; constructioncomponentCount = constructioncomponentCount + 5; computerCount = computerCount + 6; radiocomponentCount = radiocomponentCount + 4; detectorcomponentCount = detectorcomponentCount + 6; steelplateCount = steelplateCount + 2; break;
case "Small Battery": steelplateCount = steelplateCount + 2; constructioncomponentCount = constructioncomponentCount + 1; powercellCount = powercellCount + 2; break;
case "Small Cargo Container": interiorplateCount = interiorplateCount + 2; constructioncomponentCount = constructioncomponentCount + 1; computerCount = computerCount + 1; motorCount = motorCount + 1; displayCount = displayCount + 1; interiorplateCount = interiorplateCount + 1; break;
case "Small Conveyor Sorter": interiorplateCount = interiorplateCount + 4; constructioncomponentCount = constructioncomponentCount + 10; smallsteeltubeCount = smallsteeltubeCount + 5; computerCount = computerCount + 5; motorCount = motorCount + 2; constructioncomponentCount = constructioncomponentCount + 2; interiorplateCount = interiorplateCount + 1; break;
case "Small Conveyor Tube": interiorplateCount = interiorplateCount + 1; motorCount = motorCount + 1; constructioncomponentCount = constructioncomponentCount + 1; break;
case "Small Conveyor": interiorplateCount = interiorplateCount + 2; constructioncomponentCount = constructioncomponentCount + 4; motorCount = motorCount + 1; interiorplateCount = interiorplateCount + 2; break;
case "Small Curved Conveyor Tube": interiorplateCount = interiorplateCount + 1; motorCount = motorCount + 1; constructioncomponentCount = constructioncomponentCount + 1; break;
case "Small Reactor": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 10; metalgridCount = metalgridCount + 2; largesteeltubeCount = largesteeltubeCount + 1; reactorcomponentCount = reactorcomponentCount + 3; motorCount = motorCount + 1; computerCount = computerCount + 10; steelplateCount = steelplateCount + 2; break;
case "Solar Panel": steelplateCount = steelplateCount + 2; constructioncomponentCount = constructioncomponentCount + 1; girderCount = girderCount + 4; computerCount = computerCount + 1; solarcellCount = solarcellCount + 8; constructioncomponentCount = constructioncomponentCount + 1; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Sound Block": interiorplateCount = interiorplateCount + 1; constructioncomponentCount = constructioncomponentCount + 6; computerCount = computerCount + 3; interiorplateCount = interiorplateCount + 3; break;
case "Space Ball": steelplateCount = steelplateCount + 50; constructioncomponentCount = constructioncomponentCount + 10; computerCount = computerCount + 7; gravgencomponentCount = gravgencomponentCount + 1; steelplateCount = steelplateCount + 20; break;
case "Spotlight": steelplateCount = steelplateCount + 1; largesteeltubeCount = largesteeltubeCount + 1; interiorplateCount = interiorplateCount + 1; constructioncomponentCount = constructioncomponentCount + 1; bulletproofglassCount = bulletproofglassCount + 2; break;
case "Survival kit": steelplateCount = steelplateCount + 1; constructioncomponentCount = constructioncomponentCount + 2; medcomponentCount = medcomponentCount + 3; motorCount = motorCount + 4; displayCount = displayCount + 1; computerCount = computerCount + 5; steelplateCount = steelplateCount + 5; break;
case "Text panel": interiorplateCount = interiorplateCount + 1; constructioncomponentCount = constructioncomponentCount + 4; computerCount = computerCount + 4; displayCount = displayCount + 3; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Timer Block": interiorplateCount = interiorplateCount + 2; constructioncomponentCount = constructioncomponentCount + 2; computerCount = computerCount + 1; constructioncomponentCount = constructioncomponentCount + 1; break;
case "Top Piston Part": steelplateCount = steelplateCount + 4; largesteeltubeCount = largesteeltubeCount + 2; break;
case "Transparent LCD": constructioncomponentCount = constructioncomponentCount + 4; computerCount = computerCount + 4; displayCount = displayCount + 3; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Warhead": steelplateCount = steelplateCount + 1; girderCount = girderCount + 1; constructioncomponentCount = constructioncomponentCount + 1; smallsteeltubeCount = smallsteeltubeCount + 2; computerCount = computerCount + 1; explosivesCount = explosivesCount + 2; steelplateCount = steelplateCount + 3; break;
case "Welder": steelplateCount = steelplateCount + 10; constructioncomponentCount = constructioncomponentCount + 15; smallsteeltubeCount = smallsteeltubeCount + 6; motorCount = motorCount + 2; computerCount = computerCount + 2; constructioncomponentCount = constructioncomponentCount + 2; steelplateCount = steelplateCount + 2; break;
case "Wide LCD panel": interiorplateCount = interiorplateCount + 1; constructioncomponentCount = constructioncomponentCount + 8; computerCount = computerCount + 8; displayCount = displayCount + 6; bulletproofglassCount = bulletproofglassCount + 2; break;
case "Window 1x1 Face Inv.": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 1; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x1 Face": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 1; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x1 Flat Inv.": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 1; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x1 Flat": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 1; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x1 Side Inv": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 1; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x1 Side": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 1; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x1 Slope": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 1; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x2 Face Inv.": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 2; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x2 Face": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 2; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x2 Flat Inv.": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 2; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x2 Flat": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 2; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x2 Side Left Inv": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 2; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x2 Side Left": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 2; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x2 Side Right Inv": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 2; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x2 Side Right": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 2; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 1x2 Slope": girderCount = girderCount + 1; bulletproofglassCount = bulletproofglassCount + 2; bulletproofglassCount = bulletproofglassCount + 1; break;
case "Window 2x3 Flat Inv.": girderCount = girderCount + 2; bulletproofglassCount = bulletproofglassCount + 6; bulletproofglassCount = bulletproofglassCount + 2; break;
case "Window 2x3 Flat": girderCount = girderCount + 2; bulletproofglassCount = bulletproofglassCount + 6; bulletproofglassCount = bulletproofglassCount + 2; break;
case "Window 3x3 Flat Inv.": girderCount = girderCount + 3; bulletproofglassCount = bulletproofglassCount + 9; bulletproofglassCount = bulletproofglassCount + 3; break;
case "Window 3x3 Flat": girderCount = girderCount + 3; bulletproofglassCount = bulletproofglassCount + 9; bulletproofglassCount = bulletproofglassCount + 3; break;
