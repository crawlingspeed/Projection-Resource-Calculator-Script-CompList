                    case "Armor blocks":
                        if (lightArmorOnly)
                            steelplateCount = steelplateCount + 25;
                        else
                        {
                            steelplateCount = steelplateCount + 150;
                            metalgridCount = metalgridCount + 50;
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
                        steelplateCount = steelplateCount + 25;
                        break;
                    //kingfish fixed large start
                    // piston rotors are prolly wrong						      
                    //safezone not included
case "Advanced Rotor Part":   steelplateCount= steelplateCount + 30;largesteeltubeCount= largesteeltubeCount + 10; break;
case "Advanced Rotor":   steelplateCount= steelplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10;largesteeltubeCount= largesteeltubeCount + 4;motorCount= motorCount + 4;computerCount= computerCount + 2;steelplateCount= steelplateCount + 5; break;
case "Air Vent":   steelplateCount= steelplateCount + 30;constructioncomponentCount= constructioncomponentCount + 20;motorCount= motorCount + 10;computerCount= computerCount + 5;steelplateCount= steelplateCount + 15; break;
case "Airtight Hangar Door":   steelplateCount= steelplateCount + 250;constructioncomponentCount= constructioncomponentCount + 15;smallsteeltubeCount= smallsteeltubeCount + 40;motorCount= motorCount + 16;computerCount= computerCount + 2;constructioncomponentCount= constructioncomponentCount + 25;steelplateCount= steelplateCount + 100; break;
case "Antenna":   steelplateCount= steelplateCount + 60;largesteeltubeCount= largesteeltubeCount + 40;smallsteeltubeCount= smallsteeltubeCount + 60;constructioncomponentCount= constructioncomponentCount + 30;computerCount= computerCount + 8;radiocomponentCount= radiocomponentCount + 40;steelplateCount= steelplateCount + 20; break;
case "Armory Lockers":   interiorplateCount= interiorplateCount + 25;constructioncomponentCount= constructioncomponentCount + 15;displayCount= displayCount + 4;bulletproofglassCount= bulletproofglassCount + 10;constructioncomponentCount= constructioncomponentCount + 15; break;
case "Armory":   interiorplateCount= interiorplateCount + 30;constructioncomponentCount= constructioncomponentCount + 20;displayCount= displayCount + 4;bulletproofglassCount= bulletproofglassCount + 10;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Artificial Mass":   steelplateCount= steelplateCount + 30;superconductorconduitCount= superconductorconduitCount + 20;constructioncomponentCount= constructioncomponentCount + 30;computerCount= computerCount + 20;gravgencomponentCount= gravgencomponentCount + 9;steelplateCount= steelplateCount + 60; break;
case "Assembler":   steelplateCount= steelplateCount + 120;constructioncomponentCount= constructioncomponentCount + 80;motorCount= motorCount + 20;displayCount= displayCount + 10;metalgridCount= metalgridCount + 10;computerCount= computerCount + 160;steelplateCount= steelplateCount + 20; break;
case "ATM":   steelplateCount= steelplateCount + 10;constructioncomponentCount= constructioncomponentCount + 20;motorCount= motorCount + 2;computerCount= computerCount + 10;displayCount= displayCount + 4;steelplateCount= steelplateCount + 10; break;
case "Atmospheric Thrusters":   steelplateCount= steelplateCount + 15;constructioncomponentCount= constructioncomponentCount + 30;largesteeltubeCount= largesteeltubeCount + 8;metalgridCount= metalgridCount + 10;motorCount= motorCount + 110;constructioncomponentCount= constructioncomponentCount + 20;steelplateCount= steelplateCount + 20; break;
case "Basic Assembler":   steelplateCount= steelplateCount + 60;constructioncomponentCount= constructioncomponentCount + 40;motorCount= motorCount + 10;displayCount= displayCount + 4;computerCount= computerCount + 80;steelplateCount= steelplateCount + 20; break;
case "Basic Refinery":   steelplateCount= steelplateCount + 100;constructioncomponentCount= constructioncomponentCount + 20;motorCount= motorCount + 10;computerCount= computerCount + 10;steelplateCount= steelplateCount + 20; break;
case "Bathroom":   interiorplateCount= interiorplateCount + 30;constructioncomponentCount= constructioncomponentCount + 20;smallsteeltubeCount= smallsteeltubeCount + 8;motorCount= motorCount + 4;largesteeltubeCount= largesteeltubeCount + 2;constructioncomponentCount= constructioncomponentCount + 20; break;
case "Battery":   steelplateCount= steelplateCount + 20;constructioncomponentCount= constructioncomponentCount + 10;powercellCount= powercellCount + 80;computerCount= computerCount + 25;constructioncomponentCount= constructioncomponentCount + 20;steelplateCount= steelplateCount + 60; break;
case "Beacon":   steelplateCount= steelplateCount + 40;constructioncomponentCount= constructioncomponentCount + 30;largesteeltubeCount= largesteeltubeCount + 20;computerCount= computerCount + 10;radiocomponentCount= radiocomponentCount + 40;steelplateCount= steelplateCount + 40; break;
case "Bed":   interiorplateCount= interiorplateCount + 30;constructioncomponentCount= constructioncomponentCount + 20;smallsteeltubeCount= smallsteeltubeCount + 8;bulletproofglassCount= bulletproofglassCount + 10;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Blast door corner inverted":   steelplateCount= steelplateCount + 120;steelplateCount= steelplateCount + 15; break;
case "Blast door corner":   steelplateCount= steelplateCount + 105;steelplateCount= steelplateCount + 15; break;
case "Blast door edge":   steelplateCount= steelplateCount + 115;steelplateCount= steelplateCount + 15; break;
case "Blast doors":   steelplateCount= steelplateCount + 125;steelplateCount= steelplateCount + 15; break;
case "Button Panel":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10;computerCount= computerCount + 20;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Camera":   steelplateCount= steelplateCount + 1;computerCount= computerCount + 3;steelplateCount= steelplateCount + 1; break;
case "Chairless Desk Corner":   interiorplateCount= interiorplateCount + 15;constructioncomponentCount= constructioncomponentCount + 15;interiorplateCount= interiorplateCount + 5;constructioncomponentCount= constructioncomponentCount + 5; break;
case "Chairless Desk":   interiorplateCount= interiorplateCount + 20;constructioncomponentCount= constructioncomponentCount + 20;interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Cockpit":   steelplateCount= steelplateCount + 20;constructioncomponentCount= constructioncomponentCount + 20;motorCount= motorCount + 1;displayCount= displayCount + 8;computerCount= computerCount + 100;steelplateCount= steelplateCount + 10;bulletproofglassCount= bulletproofglassCount + 60; break;
case "Collector":   steelplateCount= steelplateCount + 30;constructioncomponentCount= constructioncomponentCount + 50;smallsteeltubeCount= smallsteeltubeCount + 12;motorCount= motorCount + 8;displayCount= displayCount + 4;computerCount= computerCount + 10;steelplateCount= steelplateCount + 15; break;
case "Connector":   steelplateCount= steelplateCount + 130;constructioncomponentCount= constructioncomponentCount + 40;smallsteeltubeCount= smallsteeltubeCount + 12;motorCount= motorCount + 8;computerCount= computerCount + 20;steelplateCount= steelplateCount + 20; break;
case "Console Block":   interiorplateCount= interiorplateCount + 20;constructioncomponentCount= constructioncomponentCount + 20;computerCount= computerCount + 8;displayCount= displayCount + 10;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Contracts":   steelplateCount= steelplateCount + 20;constructioncomponentCount= constructioncomponentCount + 20;motorCount= motorCount + 6;displayCount= displayCount + 4;computerCount= computerCount + 10;steelplateCount= steelplateCount + 10; break;
case "Control Panel":   steelplateCount= steelplateCount + 1;constructioncomponentCount= constructioncomponentCount + 1;computerCount= computerCount + 1;displayCount= displayCount + 1; break;
case "Control Seat":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 20;motorCount= motorCount + 2;computerCount= computerCount + 100;displayCount= displayCount + 6;constructioncomponentCount= constructioncomponentCount + 10;interiorplateCount= interiorplateCount + 20; break;
case "Control Stations":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 15;motorCount= motorCount + 2;computerCount= computerCount + 100;displayCount= displayCount + 10;constructioncomponentCount= constructioncomponentCount + 5;interiorplateCount= interiorplateCount + 10; break;
case "Conveyor Junction":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 20;smallsteeltubeCount= smallsteeltubeCount + 20;motorCount= motorCount + 6;constructioncomponentCount= constructioncomponentCount + 10;interiorplateCount= interiorplateCount + 10; break;
case "Conveyor Sorter":   interiorplateCount= interiorplateCount + 40;constructioncomponentCount= constructioncomponentCount + 100;smallsteeltubeCount= smallsteeltubeCount + 50;computerCount= computerCount + 20;motorCount= motorCount + 2;constructioncomponentCount= constructioncomponentCount + 20;interiorplateCount= interiorplateCount + 10; break;
case "Conveyor Tube":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 20;smallsteeltubeCount= smallsteeltubeCount + 12;motorCount= motorCount + 6;interiorplateCount= interiorplateCount + 4; break;
case "Corner Couch":   interiorplateCount= interiorplateCount + 25;constructioncomponentCount= constructioncomponentCount + 25;interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Corner LCD Bottom":   constructioncomponentCount= constructioncomponentCount + 5;computerCount= computerCount + 3;displayCount= displayCount + 1; break;
case "Corner LCD Flat Bottom":   constructioncomponentCount= constructioncomponentCount + 5;computerCount= computerCount + 3;displayCount= displayCount + 1; break;
case "Corner LCD Flat Top":   constructioncomponentCount= constructioncomponentCount + 5;computerCount= computerCount + 3;displayCount= displayCount + 1; break;
case "Corner LCD Top":   constructioncomponentCount= constructioncomponentCount + 5;computerCount= computerCount + 3;displayCount= displayCount + 1; break;
case "Corner Light - Double":   constructioncomponentCount= constructioncomponentCount + 6; break;
case "Corner Light":   constructioncomponentCount= constructioncomponentCount + 3; break;
case "Couch":   interiorplateCount= interiorplateCount + 20;constructioncomponentCount= constructioncomponentCount + 20;interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Cover Walls":   steelplateCount= steelplateCount + 4;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Cryo Chamber":   interiorplateCount= interiorplateCount + 30;constructioncomponentCount= constructioncomponentCount + 20;motorCount= motorCount + 8;displayCount= displayCount + 8;medcomponentCount= medcomponentCount + 3;computerCount= computerCount + 30;interiorplateCount= interiorplateCount + 10;bulletproofglassCount= bulletproofglassCount + 10; break;
case "Curved Conveyor Tube":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 20;smallsteeltubeCount= smallsteeltubeCount + 12;motorCount= motorCount + 6;interiorplateCount= interiorplateCount + 4; break;
case "Dead Astronaut":   steelplateCount= steelplateCount + 13;superconductorconduitCount= superconductorconduitCount + 13; break;
case "Debug spheres 1":   steelplateCount= steelplateCount + 10;computerCount= computerCount + 20; break;
case "Debug spheres 2 (no metal)":   steelplateCount= steelplateCount + 10;computerCount= computerCount + 20; break;
case "Debug spheres 3 (fixed gloss)":   steelplateCount= steelplateCount + 10;computerCount= computerCount + 20; break;
case "Decoy":   steelplateCount= steelplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10;computerCount= computerCount + 10;radiocomponentCount= radiocomponentCount + 1;largesteeltubeCount= largesteeltubeCount + 2;steelplateCount= steelplateCount + 20; break;
case "Desk Corner":   interiorplateCount= interiorplateCount + 15;constructioncomponentCount= constructioncomponentCount + 15;interiorplateCount= interiorplateCount + 5;constructioncomponentCount= constructioncomponentCount + 5; break;
case "Desk":   interiorplateCount= interiorplateCount + 20;constructioncomponentCount= constructioncomponentCount + 20;interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Diagonal Window":   interiorplateCount= interiorplateCount + 16;constructioncomponentCount= constructioncomponentCount + 12;smallsteeltubeCount= smallsteeltubeCount + 6; break;
case "Dispenser":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10;motorCount= motorCount + 4;displayCount= displayCount + 10;computerCount= computerCount + 10;interiorplateCount= interiorplateCount + 10; break;
case "Door":   interiorplateCount= interiorplateCount + 4;constructioncomponentCount= constructioncomponentCount + 15;smallsteeltubeCount= smallsteeltubeCount + 4;motorCount= motorCount + 2;displayCount= displayCount + 1;computerCount= computerCount + 2;interiorplateCount= interiorplateCount + 6;constructioncomponentCount= constructioncomponentCount + 25;steelplateCount= steelplateCount + 8; break;
case "Drill":   steelplateCount= steelplateCount + 180;constructioncomponentCount= constructioncomponentCount + 40;largesteeltubeCount= largesteeltubeCount + 12;motorCount= motorCount + 5;computerCount= computerCount + 5;steelplateCount= steelplateCount + 120; break;
case "Flight Seat":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 15;motorCount= motorCount + 2;computerCount= computerCount + 100;displayCount= displayCount + 4;constructioncomponentCount= constructioncomponentCount + 5;interiorplateCount= interiorplateCount + 10; break;
case "Freight 1":   interiorplateCount= interiorplateCount + 5;constructioncomponentCount= constructioncomponentCount + 8;interiorplateCount= interiorplateCount + 1; break;
case "Freight 2":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 16;interiorplateCount= interiorplateCount + 2; break;
case "Freight 3":   interiorplateCount= interiorplateCount + 15;constructioncomponentCount= constructioncomponentCount + 24;interiorplateCount= interiorplateCount + 3; break;
case "Gatling Turret":   steelplateCount= steelplateCount + 5;constructioncomponentCount= constructioncomponentCount + 25;metalgridCount= metalgridCount + 15;smallsteeltubeCount= smallsteeltubeCount + 6;motorCount= motorCount + 8;computerCount= computerCount + 10;constructioncomponentCount= constructioncomponentCount + 5;steelplateCount= steelplateCount + 15; break;
case "Grated Catwalk Corner":   constructioncomponentCount= constructioncomponentCount + 14;girderCount= girderCount + 4;smallsteeltubeCount= smallsteeltubeCount + 32;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Grated Catwalk End":   constructioncomponentCount= constructioncomponentCount + 16;girderCount= girderCount + 4;smallsteeltubeCount= smallsteeltubeCount + 38;constructioncomponentCount= constructioncomponentCount + 12; break;
case "Grated Catwalk Half Left":   constructioncomponentCount= constructioncomponentCount + 16;girderCount= girderCount + 4;smallsteeltubeCount= smallsteeltubeCount + 36;constructioncomponentCount= constructioncomponentCount + 12; break;
case "Grated Catwalk Half Right":   constructioncomponentCount= constructioncomponentCount + 16;girderCount= girderCount + 4;smallsteeltubeCount= smallsteeltubeCount + 36;constructioncomponentCount= constructioncomponentCount + 12; break;
case "Grated Catwalk Straight":   constructioncomponentCount= constructioncomponentCount + 14;girderCount= girderCount + 4;smallsteeltubeCount= smallsteeltubeCount + 32;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Grated Catwalk Wall":   constructioncomponentCount= constructioncomponentCount + 12;girderCount= girderCount + 4;smallsteeltubeCount= smallsteeltubeCount + 26;constructioncomponentCount= constructioncomponentCount + 8; break;
case "Grated Catwalk":   constructioncomponentCount= constructioncomponentCount + 10;girderCount= girderCount + 4;smallsteeltubeCount= smallsteeltubeCount + 20;constructioncomponentCount= constructioncomponentCount + 6; break;
case "Grated half stairs mirrored":   constructioncomponentCount= constructioncomponentCount + 10;smallsteeltubeCount= smallsteeltubeCount + 6;interiorplateCount= interiorplateCount + 8;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Grated half stairs":   constructioncomponentCount= constructioncomponentCount + 10;smallsteeltubeCount= smallsteeltubeCount + 6;interiorplateCount= interiorplateCount + 8;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Grated stairs":   constructioncomponentCount= constructioncomponentCount + 12;smallsteeltubeCount= smallsteeltubeCount + 12;interiorplateCount= interiorplateCount + 16;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Gravity Generator":   steelplateCount= steelplateCount + 54;gravgencomponentCount= gravgencomponentCount + 6;constructioncomponentCount= constructioncomponentCount + 60;steelplateCount= steelplateCount + 56;largesteeltubeCount= largesteeltubeCount + 4;motorCount= motorCount + 6;computerCount= computerCount + 40;steelplateCount= steelplateCount + 40; break;
case "Grinder":   steelplateCount= steelplateCount + 15;constructioncomponentCount= constructioncomponentCount + 25;largesteeltubeCount= largesteeltubeCount + 1;motorCount= motorCount + 4;computerCount= computerCount + 2;constructioncomponentCount= constructioncomponentCount + 5;steelplateCount= steelplateCount + 5; break;
case "Gyroscope":   steelplateCount= steelplateCount + 500;constructioncomponentCount= constructioncomponentCount + 40;largesteeltubeCount= largesteeltubeCount + 4;metalgridCount= metalgridCount + 50;motorCount= motorCount + 4;computerCount= computerCount + 5;steelplateCount= steelplateCount + 100; break;
case "Half Cover Wall":   steelplateCount= steelplateCount + 2;constructioncomponentCount= constructioncomponentCount + 6; break;
case "Hydrogen Engine":   steelplateCount= steelplateCount + 80;constructioncomponentCount= constructioncomponentCount + 60;largesteeltubeCount= largesteeltubeCount + 12;smallsteeltubeCount= smallsteeltubeCount + 20;motorCount= motorCount + 12;computerCount= computerCount + 4;powercellCount= powercellCount + 1;constructioncomponentCount= constructioncomponentCount + 10;steelplateCount= steelplateCount + 20; break;
case "Hydrogen Tank":   steelplateCount= steelplateCount + 160;largesteeltubeCount= largesteeltubeCount + 80;smallsteeltubeCount= smallsteeltubeCount + 60;computerCount= computerCount + 8;constructioncomponentCount= constructioncomponentCount + 40;steelplateCount= steelplateCount + 120; break;
case "Hydrogen Thrusters":   steelplateCount= steelplateCount + 15;constructioncomponentCount= constructioncomponentCount + 40;metalgridCount= metalgridCount + 40;largesteeltubeCount= largesteeltubeCount + 8;constructioncomponentCount= constructioncomponentCount + 20;steelplateCount= steelplateCount + 10; break;
case "Industrial Cockpit":   steelplateCount= steelplateCount + 20;constructioncomponentCount= constructioncomponentCount + 30;metalgridCount= metalgridCount + 15;motorCount= motorCount + 2;displayCount= displayCount + 10;computerCount= computerCount + 60;bulletproofglassCount= bulletproofglassCount + 80;smallsteeltubeCount= smallsteeltubeCount + 10; break;
case "Interior Light":   constructioncomponentCount= constructioncomponentCount + 2; break;
case "Interior Pillar":   interiorplateCount= interiorplateCount + 25;constructioncomponentCount= constructioncomponentCount + 10;smallsteeltubeCount= smallsteeltubeCount + 4; break;
case "Interior Turret":   interiorplateCount= interiorplateCount + 6;constructioncomponentCount= constructioncomponentCount + 15;smallsteeltubeCount= smallsteeltubeCount + 1;motorCount= motorCount + 2;computerCount= computerCount + 5;constructioncomponentCount= constructioncomponentCount + 5;steelplateCount= steelplateCount + 4; break;
case "Interior Wall":   interiorplateCount= interiorplateCount + 20;constructioncomponentCount= constructioncomponentCount + 8;interiorplateCount= interiorplateCount + 5;constructioncomponentCount= constructioncomponentCount + 2; break;
case "Ion Thrusters":   steelplateCount= steelplateCount + 15;constructioncomponentCount= constructioncomponentCount + 40;largesteeltubeCount= largesteeltubeCount + 8;thrustercomponentCount= thrustercomponentCount + 80;constructioncomponentCount= constructioncomponentCount + 20;steelplateCount= steelplateCount + 10; break;
case "Jukebox":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10;computerCount= computerCount + 4;displayCount= displayCount + 4;interiorplateCount= interiorplateCount + 5; break;
case "Jump Drive":   steelplateCount= steelplateCount + 40;metalgridCount= metalgridCount + 50;gravgencomponentCount= gravgencomponentCount + 20;detectorcomponentCount= detectorcomponentCount + 20;powercellCount= powercellCount + 120;superconductorconduitCount= superconductorconduitCount + 1000;computerCount= computerCount + 300;constructioncomponentCount= constructioncomponentCount + 40;steelplateCount= steelplateCount + 20; break;
case "Kitchen":   interiorplateCount= interiorplateCount + 20;constructioncomponentCount= constructioncomponentCount + 30;largesteeltubeCount= largesteeltubeCount + 6;motorCount= motorCount + 6;bulletproofglassCount= bulletproofglassCount + 4; break;
case "Lab Equipment":   interiorplateCount= interiorplateCount + 15;constructioncomponentCount= constructioncomponentCount + 10;motorCount= motorCount + 1;bulletproofglassCount= bulletproofglassCount + 4;constructioncomponentCount= constructioncomponentCount + 5; break;
case "Ladder":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10;smallsteeltubeCount= smallsteeltubeCount + 10;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Landing Gear":   steelplateCount= steelplateCount + 100;constructioncomponentCount= constructioncomponentCount + 20;motorCount= motorCount + 6;steelplateCount= steelplateCount + 50; break;
case "Large Atmospheric Thruster":   steelplateCount= steelplateCount + 100;constructioncomponentCount= constructioncomponentCount + 40;largesteeltubeCount= largesteeltubeCount + 50;metalgridCount= metalgridCount + 40;motorCount= motorCount + 1100;constructioncomponentCount= constructioncomponentCount + 20;steelplateCount= steelplateCount + 130; break;
case "Large Cargo Container":   interiorplateCount= interiorplateCount + 300;constructioncomponentCount= constructioncomponentCount + 60;metalgridCount= metalgridCount + 24;smallsteeltubeCount= smallsteeltubeCount + 60;motorCount= motorCount + 20;displayCount= displayCount + 1;computerCount= computerCount + 8;constructioncomponentCount= constructioncomponentCount + 20;interiorplateCount= interiorplateCount + 60; break;
case "Large Hydrogen Thruster":   steelplateCount= steelplateCount + 100;constructioncomponentCount= constructioncomponentCount + 150;metalgridCount= metalgridCount + 250;largesteeltubeCount= largesteeltubeCount + 40;constructioncomponentCount= constructioncomponentCount + 30;steelplateCount= steelplateCount + 50; break;
case "Large Ion Thruster":   steelplateCount= steelplateCount + 100;constructioncomponentCount= constructioncomponentCount + 70;largesteeltubeCount= largesteeltubeCount + 40;thrustercomponentCount= thrustercomponentCount + 960;constructioncomponentCount= constructioncomponentCount + 30;steelplateCount= steelplateCount + 50; break;
case "Large Reactor":   steelplateCount= steelplateCount + 800;constructioncomponentCount= constructioncomponentCount + 70;metalgridCount= metalgridCount + 40;largesteeltubeCount= largesteeltubeCount + 40;superconductorconduitCount= superconductorconduitCount + 100;reactorcomponentCount= reactorcomponentCount + 2000;motorCount= motorCount + 20;computerCount= computerCount + 75;steelplateCount= steelplateCount + 200; break;
case "LargeRailStraight":   steelplateCount= steelplateCount + 12;constructioncomponentCount= constructioncomponentCount + 8;largesteeltubeCount= largesteeltubeCount + 4; break;
case "Laser Antenna":   steelplateCount= steelplateCount + 40;constructioncomponentCount= constructioncomponentCount + 40;motorCount= motorCount + 16;detectorcomponentCount= detectorcomponentCount + 30;radiocomponentCount= radiocomponentCount + 20;superconductorconduitCount= superconductorconduitCount + 100;computerCount= computerCount + 50;bulletproofglassCount= bulletproofglassCount + 4;steelplateCount= steelplateCount + 10; break;
case "LCD Panel":   interiorplateCount= interiorplateCount + 1;constructioncomponentCount= constructioncomponentCount + 6;computerCount= computerCount + 6;displayCount= displayCount + 10;bulletproofglassCount= bulletproofglassCount + 6; break;
case "Lockers":   interiorplateCount= interiorplateCount + 20;constructioncomponentCount= constructioncomponentCount + 10;displayCount= displayCount + 3;computerCount= computerCount + 2;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Medical Room":   interiorplateCount= interiorplateCount + 220;constructioncomponentCount= constructioncomponentCount + 80;metalgridCount= metalgridCount + 60;smallsteeltubeCount= smallsteeltubeCount + 20;largesteeltubeCount= largesteeltubeCount + 5;displayCount= displayCount + 10;computerCount= computerCount + 10;medcomponentCount= medcomponentCount + 15;interiorplateCount= interiorplateCount + 20; break;
case "Medical Station":   interiorplateCount= interiorplateCount + 15;constructioncomponentCount= constructioncomponentCount + 10;motorCount= motorCount + 2;medcomponentCount= medcomponentCount + 1;displayCount= displayCount + 2;constructioncomponentCount= constructioncomponentCount + 5; break;
case "Merge Block":   steelplateCount= steelplateCount + 5;constructioncomponentCount= constructioncomponentCount + 15;motorCount= motorCount + 2;largesteeltubeCount= largesteeltubeCount + 6;computerCount= computerCount + 2;steelplateCount= steelplateCount + 7; break;
case "Missile Turret":   steelplateCount= steelplateCount + 5;constructioncomponentCount= constructioncomponentCount + 30;metalgridCount= metalgridCount + 5;largesteeltubeCount= largesteeltubeCount + 6;motorCount= motorCount + 16;computerCount= computerCount + 12;constructioncomponentCount= constructioncomponentCount + 10;steelplateCount= steelplateCount + 15; break;
case "O2/H2 Generator":   steelplateCount= steelplateCount + 110;constructioncomponentCount= constructioncomponentCount + 5;largesteeltubeCount= largesteeltubeCount + 2;motorCount= motorCount + 4;computerCount= computerCount + 5;steelplateCount= steelplateCount + 10; break;
case "Ore Detector":   steelplateCount= steelplateCount + 30;constructioncomponentCount= constructioncomponentCount + 40;motorCount= motorCount + 5;computerCount= computerCount + 25;detectorcomponentCount= detectorcomponentCount + 20;steelplateCount= steelplateCount + 20; break;
case "Oxygen Farm":   steelplateCount= steelplateCount + 40;bulletproofglassCount= bulletproofglassCount + 60;largesteeltubeCount= largesteeltubeCount + 20;smallsteeltubeCount= smallsteeltubeCount + 10;constructioncomponentCount= constructioncomponentCount + 20;computerCount= computerCount + 20;bulletproofglassCount= bulletproofglassCount + 40; break;
case "Oxygen Tank":   steelplateCount= steelplateCount + 60;largesteeltubeCount= largesteeltubeCount + 40;smallsteeltubeCount= smallsteeltubeCount + 60;computerCount= computerCount + 8;constructioncomponentCount= constructioncomponentCount + 40;steelplateCount= steelplateCount + 20; break;
case "Parachute Hatch":   steelplateCount= steelplateCount + 5;constructioncomponentCount= constructioncomponentCount + 25;smallsteeltubeCount= smallsteeltubeCount + 5;motorCount= motorCount + 3;computerCount= computerCount + 2;steelplateCount= steelplateCount + 4; break;
case "Passage":   interiorplateCount= interiorplateCount + 74;constructioncomponentCount= constructioncomponentCount + 20;smallsteeltubeCount= smallsteeltubeCount + 48; break;
case "Passenger Seat":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 20;interiorplateCount= interiorplateCount + 10; break;
case "Piston":   steelplateCount= steelplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10;largesteeltubeCount= largesteeltubeCount + 4;motorCount= motorCount + 4;computerCount= computerCount + 2;steelplateCount= steelplateCount + 5; break;
case "Planters":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10;smallsteeltubeCount= smallsteeltubeCount + 8;bulletproofglassCount= bulletproofglassCount + 8;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Power Efficiency Module":   steelplateCount= steelplateCount + 80;constructioncomponentCount= constructioncomponentCount + 40;smallsteeltubeCount= smallsteeltubeCount + 20;powercellCount= powercellCount + 20;motorCount= motorCount + 4;steelplateCount= steelplateCount + 20; break;
case "Programmable block":   steelplateCount= steelplateCount + 11;constructioncomponentCount= constructioncomponentCount + 4;largesteeltubeCount= largesteeltubeCount + 2;motorCount= motorCount + 1;displayCount= displayCount + 1;computerCount= computerCount + 2;steelplateCount= steelplateCount + 10; break;
case "Projector":   steelplateCount= steelplateCount + 11;constructioncomponentCount= constructioncomponentCount + 4;largesteeltubeCount= largesteeltubeCount + 2;motorCount= motorCount + 1;computerCount= computerCount + 2;steelplateCount= steelplateCount + 10; break;
case "Railing Corner":   constructioncomponentCount= constructioncomponentCount + 8;smallsteeltubeCount= smallsteeltubeCount + 12;constructioncomponentCount= constructioncomponentCount + 8; break;
case "Railing Diagonal":   constructioncomponentCount= constructioncomponentCount + 6;smallsteeltubeCount= smallsteeltubeCount + 9;constructioncomponentCount= constructioncomponentCount + 6; break;
case "Railing Double":   constructioncomponentCount= constructioncomponentCount + 8;smallsteeltubeCount= smallsteeltubeCount + 12;constructioncomponentCount= constructioncomponentCount + 8; break;
case "Railing Half Left":   constructioncomponentCount= constructioncomponentCount + 4;smallsteeltubeCount= smallsteeltubeCount + 4;constructioncomponentCount= constructioncomponentCount + 4; break;
case "Railing Half Right":   constructioncomponentCount= constructioncomponentCount + 4;smallsteeltubeCount= smallsteeltubeCount + 4;constructioncomponentCount= constructioncomponentCount + 4; break;
case "Railing Straight":   constructioncomponentCount= constructioncomponentCount + 4;smallsteeltubeCount= smallsteeltubeCount + 6;constructioncomponentCount= constructioncomponentCount + 4; break;
case "Ramp":   interiorplateCount= interiorplateCount + 60;constructioncomponentCount= constructioncomponentCount + 16;interiorplateCount= interiorplateCount + 10; break;
case "Refinery":   steelplateCount= steelplateCount + 1100;constructioncomponentCount= constructioncomponentCount + 40;largesteeltubeCount= largesteeltubeCount + 20;motorCount= motorCount + 16;metalgridCount= metalgridCount + 20;computerCount= computerCount + 20;steelplateCount= steelplateCount + 100; break;
case "Remote Control":   interiorplateCount= interiorplateCount + 5;constructioncomponentCount= constructioncomponentCount + 10;motorCount= motorCount + 1;computerCount= computerCount + 15;interiorplateCount= interiorplateCount + 5; break;
case "Rocket Launcher":   steelplateCount= steelplateCount + 20;constructioncomponentCount= constructioncomponentCount + 8;metalgridCount= metalgridCount + 30;largesteeltubeCount= largesteeltubeCount + 25;motorCount= motorCount + 6;computerCount= computerCount + 4;steelplateCount= steelplateCount + 15; break;
case "Rotating Light":   constructioncomponentCount= constructioncomponentCount + 2;motorCount= motorCount + 1;constructioncomponentCount= constructioncomponentCount + 1; break;
case "Rotor Part":   steelplateCount= steelplateCount + 30;largesteeltubeCount= largesteeltubeCount + 6; break;
case "Rotor":   steelplateCount= steelplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10;largesteeltubeCount= largesteeltubeCount + 4;motorCount= motorCount + 4;computerCount= computerCount + 2;steelplateCount= steelplateCount + 5; break;
//case "Safe Zone":   steelplateCount= steelplateCount + 750;constructioncomponentCount= constructioncomponentCount + 180;gravgencomponentCount= gravgencomponentCount + 10;ZoneChip=5;metalgridCount= metalgridCount + 80;computerCount= computerCount + 120;steelplateCount= steelplateCount + 50; break;
case "Sensor":   interiorplateCount= interiorplateCount + 5;constructioncomponentCount= constructioncomponentCount + 5;computerCount= computerCount + 6;radiocomponentCount= radiocomponentCount + 4;detectorcomponentCount= detectorcomponentCount + 6;steelplateCount= steelplateCount + 2; break;
case "Shower":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 20;smallsteeltubeCount= smallsteeltubeCount + 12;bulletproofglassCount= bulletproofglassCount + 8;interiorplateCount= interiorplateCount + 10; break;
case "Sliding Door":   steelplateCount= steelplateCount + 5;constructioncomponentCount= constructioncomponentCount + 15;smallsteeltubeCount= smallsteeltubeCount + 4;motorCount= motorCount + 4;displayCount= displayCount + 1;computerCount= computerCount + 2;constructioncomponentCount= constructioncomponentCount + 25;bulletproofglassCount= bulletproofglassCount + 15;steelplateCount= steelplateCount + 15; break;
case "Small Cargo Container":   interiorplateCount= interiorplateCount + 30;constructioncomponentCount= constructioncomponentCount + 35;metalgridCount= metalgridCount + 4;smallsteeltubeCount= smallsteeltubeCount + 20;motorCount= motorCount + 4;displayCount= displayCount + 1;computerCount= computerCount + 2;constructioncomponentCount= constructioncomponentCount + 5;interiorplateCount= interiorplateCount + 10; break;
case "Small Reactor":   steelplateCount= steelplateCount + 50;constructioncomponentCount= constructioncomponentCount + 40;metalgridCount= metalgridCount + 4;largesteeltubeCount= largesteeltubeCount + 8;reactorcomponentCount= reactorcomponentCount + 100;motorCount= motorCount + 6;computerCount= computerCount + 25;steelplateCount= steelplateCount + 30; break;
case "Solar Panel":   steelplateCount= steelplateCount + 4;constructioncomponentCount= constructioncomponentCount + 10;girderCount= girderCount + 12;computerCount= computerCount + 4;solarcellCount= solarcellCount + 32;constructioncomponentCount= constructioncomponentCount + 4;bulletproofglassCount= bulletproofglassCount + 4; break;
case "Sound Block":   interiorplateCount= interiorplateCount + 1;constructioncomponentCount= constructioncomponentCount + 6;computerCount= computerCount + 3;interiorplateCount= interiorplateCount + 3; break;
case "Space Ball":   steelplateCount= steelplateCount + 90;constructioncomponentCount= constructioncomponentCount + 30;computerCount= computerCount + 20;gravgencomponentCount= gravgencomponentCount + 3;steelplateCount= steelplateCount + 135; break;
case "Speed Module":   steelplateCount= steelplateCount + 80;constructioncomponentCount= constructioncomponentCount + 40;smallsteeltubeCount= smallsteeltubeCount + 20;computerCount= computerCount + 60;motorCount= motorCount + 4;steelplateCount= steelplateCount + 20; break;
case "Spherical Gravity Generator":   steelplateCount= steelplateCount + 54;gravgencomponentCount= gravgencomponentCount + 6;constructioncomponentCount= constructioncomponentCount + 60;steelplateCount= steelplateCount + 56;largesteeltubeCount= largesteeltubeCount + 4;motorCount= motorCount + 6;computerCount= computerCount + 40;steelplateCount= steelplateCount + 40; break;
case "Spotlight":   steelplateCount= steelplateCount + 8;largesteeltubeCount= largesteeltubeCount + 2;interiorplateCount= interiorplateCount + 20;constructioncomponentCount= constructioncomponentCount + 15;bulletproofglassCount= bulletproofglassCount + 4; break;
case "Stairs":   interiorplateCount= interiorplateCount + 40;constructioncomponentCount= constructioncomponentCount + 30;interiorplateCount= interiorplateCount + 10; break;
case "Steel Catwalk Corner":   interiorplateCount= interiorplateCount + 20;constructioncomponentCount= constructioncomponentCount + 7;smallsteeltubeCount= smallsteeltubeCount + 25;interiorplateCount= interiorplateCount + 12; break;
case "Steel Catwalk Plate":   interiorplateCount= interiorplateCount + 15;constructioncomponentCount= constructioncomponentCount + 7;smallsteeltubeCount= smallsteeltubeCount + 17;interiorplateCount= interiorplateCount + 8; break;
case "Steel Catwalk Two Sides":   interiorplateCount= interiorplateCount + 20;constructioncomponentCount= constructioncomponentCount + 7;smallsteeltubeCount= smallsteeltubeCount + 25;interiorplateCount= interiorplateCount + 12; break;
case "Steel Catwalk":   interiorplateCount= interiorplateCount + 20;constructioncomponentCount= constructioncomponentCount + 5;smallsteeltubeCount= smallsteeltubeCount + 20;interiorplateCount= interiorplateCount + 7; break;
case "Store":   steelplateCount= steelplateCount + 20;constructioncomponentCount= constructioncomponentCount + 20;motorCount= motorCount + 6;displayCount= displayCount + 4;computerCount= computerCount + 10;steelplateCount= steelplateCount + 10; break;
case "Survival kit":   steelplateCount= steelplateCount + 20;constructioncomponentCount= constructioncomponentCount + 2;medcomponentCount= medcomponentCount + 3;motorCount= motorCount + 4;displayCount= displayCount + 1;computerCount= computerCount + 5;steelplateCount= steelplateCount + 10; break;
case "Text panel":   interiorplateCount= interiorplateCount + 1;constructioncomponentCount= constructioncomponentCount + 6;computerCount= computerCount + 6;displayCount= displayCount + 10;bulletproofglassCount= bulletproofglassCount + 2; break;
case "Timer Block":   interiorplateCount= interiorplateCount + 6;constructioncomponentCount= constructioncomponentCount + 20;computerCount= computerCount + 5;constructioncomponentCount= constructioncomponentCount + 10; break;
case "Toilet Seat":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10;smallsteeltubeCount= smallsteeltubeCount + 2;motorCount= motorCount + 2;largesteeltubeCount= largesteeltubeCount + 1;constructioncomponentCount= constructioncomponentCount + 5; break;
case "Toilet":   interiorplateCount= interiorplateCount + 30;constructioncomponentCount= constructioncomponentCount + 15;smallsteeltubeCount= smallsteeltubeCount + 8;motorCount= motorCount + 4;largesteeltubeCount= largesteeltubeCount + 2;constructioncomponentCount= constructioncomponentCount + 15; break;
case "Top Piston Part":   steelplateCount= steelplateCount + 10;largesteeltubeCount= largesteeltubeCount + 8; break;
case "Transparent LCD":   constructioncomponentCount= constructioncomponentCount + 8;computerCount= computerCount + 6;displayCount= displayCount + 10;bulletproofglassCount= bulletproofglassCount + 10; break;
case "Vending Machine":   interiorplateCount= interiorplateCount + 10;constructioncomponentCount= constructioncomponentCount + 10;motorCount= motorCount + 4;displayCount= displayCount + 4;computerCount= computerCount + 10;interiorplateCount= interiorplateCount + 10; break;
case "Vertical Window":   interiorplateCount= interiorplateCount + 12;constructioncomponentCount= constructioncomponentCount + 8;smallsteeltubeCount= smallsteeltubeCount + 4; break;
case "Warhead":   steelplateCount= steelplateCount + 10;girderCount= girderCount + 24;constructioncomponentCount= constructioncomponentCount + 12;smallsteeltubeCount= smallsteeltubeCount + 12;computerCount= computerCount + 2;explosivesCount= explosivesCount + 6;steelplateCount= steelplateCount + 10; break;
case "Welder":   steelplateCount= steelplateCount + 15;constructioncomponentCount= constructioncomponentCount + 25;largesteeltubeCount= largesteeltubeCount + 1;motorCount= motorCount + 2;computerCount= computerCount + 2;constructioncomponentCount= constructioncomponentCount + 5;steelplateCount= steelplateCount + 5; break;
case "Wide LCD panel":   interiorplateCount= interiorplateCount + 2;constructioncomponentCount= constructioncomponentCount + 12;computerCount= computerCount + 12;displayCount= displayCount + 20;bulletproofglassCount= bulletproofglassCount + 12; break;
case "Wind Turbine":   interiorplateCount= interiorplateCount + 10;motorCount= motorCount + 8;constructioncomponentCount= constructioncomponentCount + 20;girderCount= girderCount + 24;computerCount= computerCount + 2;interiorplateCount= interiorplateCount + 30; break;
case "Window 1x1 Face Inv.":   girderCount= girderCount + 11;bulletproofglassCount= bulletproofglassCount + 16;bulletproofglassCount= bulletproofglassCount + 8; break;
case "Window 1x1 Face":   girderCount= girderCount + 11;bulletproofglassCount= bulletproofglassCount + 16;bulletproofglassCount= bulletproofglassCount + 8; break;
case "Window 1x1 Flat Inv.":   girderCount= girderCount + 10;bulletproofglassCount= bulletproofglassCount + 15;bulletproofglassCount= bulletproofglassCount + 10; break;
case "Window 1x1 Flat":   girderCount= girderCount + 10;bulletproofglassCount= bulletproofglassCount + 15;bulletproofglassCount= bulletproofglassCount + 10; break;
case "Window 1x1 Side Inv":   girderCount= girderCount + 9;bulletproofglassCount= bulletproofglassCount + 12;bulletproofglassCount= bulletproofglassCount + 5; break;
case "Window 1x1 Side":   girderCount= girderCount + 9;bulletproofglassCount= bulletproofglassCount + 12;bulletproofglassCount= bulletproofglassCount + 5; break;
case "Window 1x1 Slope":   girderCount= girderCount + 12;bulletproofglassCount= bulletproofglassCount + 25;bulletproofglassCount= bulletproofglassCount + 10; break;
case "Window 1x2 Face Inv.":   girderCount= girderCount + 15;bulletproofglassCount= bulletproofglassCount + 30;bulletproofglassCount= bulletproofglassCount + 10; break;
case "Window 1x2 Face":   girderCount= girderCount + 15;bulletproofglassCount= bulletproofglassCount + 30;bulletproofglassCount= bulletproofglassCount + 10; break;
case "Window 1x2 Flat Inv.":   girderCount= girderCount + 15;bulletproofglassCount= bulletproofglassCount + 35;bulletproofglassCount= bulletproofglassCount + 15; break;
case "Window 1x2 Flat":   girderCount= girderCount + 15;bulletproofglassCount= bulletproofglassCount + 40;bulletproofglassCount= bulletproofglassCount + 10; break;
case "Window 1x2 Side Left Inv":   girderCount= girderCount + 13;bulletproofglassCount= bulletproofglassCount + 20;bulletproofglassCount= bulletproofglassCount + 6; break;
case "Window 1x2 Side Left":   girderCount= girderCount + 13;bulletproofglassCount= bulletproofglassCount + 20;bulletproofglassCount= bulletproofglassCount + 6; break;
case "Window 1x2 Side Right Inv":   girderCount= girderCount + 13;bulletproofglassCount= bulletproofglassCount + 20;bulletproofglassCount= bulletproofglassCount + 6; break;
case "Window 1x2 Side Right":   girderCount= girderCount + 13;bulletproofglassCount= bulletproofglassCount + 20;bulletproofglassCount= bulletproofglassCount + 6; break;
case "Window 1x2 Slope":   girderCount= girderCount + 16;bulletproofglassCount= bulletproofglassCount + 40;bulletproofglassCount= bulletproofglassCount + 15; break;
case "Window 2x3 Flat Inv.":   girderCount= girderCount + 25;bulletproofglassCount= bulletproofglassCount + 115;bulletproofglassCount= bulletproofglassCount + 25; break;
case "Window 2x3 Flat":   girderCount= girderCount + 25;bulletproofglassCount= bulletproofglassCount + 115;bulletproofglassCount= bulletproofglassCount + 25; break;
case "Window 3x3 Flat Inv.":   girderCount= girderCount + 40;bulletproofglassCount= bulletproofglassCount + 160;bulletproofglassCount= bulletproofglassCount + 36; break;
case "Window 3x3 Flat":   girderCount= girderCount + 40;bulletproofglassCount= bulletproofglassCount + 160;bulletproofglassCount= bulletproofglassCount + 36; break;
case "Window Wall Left":   steelplateCount= steelplateCount + 10;constructioncomponentCount= constructioncomponentCount + 5;bulletproofglassCount= bulletproofglassCount + 8;constructioncomponentCount= constructioncomponentCount + 5; break;
case "Window Wall Right":   steelplateCount= steelplateCount + 10;constructioncomponentCount= constructioncomponentCount + 5;bulletproofglassCount= bulletproofglassCount + 8;constructioncomponentCount= constructioncomponentCount + 5; break;
case "Window Wall":   steelplateCount= steelplateCount + 8;constructioncomponentCount= constructioncomponentCount + 5;bulletproofglassCount= bulletproofglassCount + 10;constructioncomponentCount= constructioncomponentCount + 5; break;
case "Yield Module":   steelplateCount= steelplateCount + 80;constructioncomponentCount= constructioncomponentCount + 50;smallsteeltubeCount= smallsteeltubeCount + 15;superconductorconduitCount= superconductorconduitCount + 20;motorCount= motorCount + 4;steelplateCount= steelplateCount + 20; break;
