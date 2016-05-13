# Declare images used by this game.
image bg lecturehall = "lecturehall.jpg"
image bg uni = "uni.jpg"
image bg meadow = "meadow.jpg"
image bg club = "club.jpg"

image bg black = Solid((0, 0, 0, 255))
image bg white = Solid((255,255,255,255))
image stormysea = "stormy_sea_by_alexlinde-d3y6mgd.jpg"
image meadow = im.Scale("morning_meadow_landscape___blender_3d_by_dee_deviantart-d8tjlxn.jpg", 1280, 720)
image splash = im.Scale("splash_6_by_paradise234-d5mcq2b.png", 1280, 720)
image beach = im.Scale("free_beach_background_by_sweetlittlevampire-d5u263t.png.jpg", 1280, 720)
image underwater = im.Scale("underwater_by_mindsqueezedesign-d6k6s2a.jpg", 1280, 720)
image underwaterboss = im.Scale("185_underwater_background_by_tigers_stock-d3cq5k5.jpg", 1280, 720)
image boom = im.Scale("particle_explosion_wallpaper___cyan_by_voltpon3-d6tpvc8.jpg", 1280, 720)

image sylvie normal = "sylvie_normal.png"
image sylvie giggle = "sylvie_giggle.png"
image sylvie smile = "sylvie_smile.png"
image sylvie surprised = "sylvie_surprised.png"

image sylvie2 normal = "sylvie2_normal.png"
image sylvie2 giggle = "sylvie2_giggle.png"
image sylvie2 smile = "sylvie2_smile.png"
image sylvie2 surprised = "sylvie2_surprised.png"

# Declare characters
define s = Character(None, kind=nvl, what_prefix="\"", what_suffix="\"",
                     what_color="#c8ffc8")
define m = Character(None, kind=nvl, what_prefix="\"", what_suffix="\"",
                     what_color="#ffc8c8")
define narrator = Character(None, kind=nvl)

# NVL configuration
init python:
    menu = nvl_menu

    # The color of a menu choice when it isn't hovered.
    style.nvl_menu_choice.idle_color = "#ccccccff"

    # The color of a menu choice when it is hovered.
    style.nvl_menu_choice.hover_color = "#ffffffff"

    # The color of the background of a menu choice, when it isn't
    # hovered.
    style.nvl_menu_choice_button.idle_background = "#00000000"

    # The color of the background of a menu choice, when it is
    # hovered.
    style.nvl_menu_choice_button.hover_background = "#ff000044"

    # How far from the left menu choices should be indented.
    style.nvl_menu_choice_button.left_margin = 20
    
    #TEXT OUTLINE
    style.default.outlines = [(2, "#5f3d35", 0, 0)]


    style.nvl_window.background = "nvl_window.png"
    style.nvl_window.xpadding = 110
    style.nvl_window.ypadding = 110

    config.empty_window = nvl_show_core
    config.window_hide_transition = dissolve
    config.window_show_transition = dissolve

# The game starts here.
label start1:
    
    play music "bensound-ofeliasdream.mp3"
    
    scene stormysea with fade
    
    window show
    
    "Victories achieved. {w=0.5}Titans slain. {w=1.0}Triumph in battle.\n\n"
    
    "With the fall of the Kingdom Chordate, Marcus the Conqueror carved his name into the annals of history.{w=1.0}\n\n"
    
    "Yet, for an event so impactful, one that led to the founding of our country,
     we know little of what happened.{w=1.0}\n\n"
    
    "Why did Marcus choose to go to war?{w=1.0}\n
     What did he encounter during his journey?{w=1.0}\n
      How did he win?{w=1.0}\n\n"
    
    "Though we may never know, we can speculate that...{w=1.0}\n"
    
    "-{i}Drowned Sea: A Treatise on the Chordaten War{/i}"
    
    stop music fadeout 1.0
    
    window hide
    nvl clear
    
    $ renpy.music.set_volume(0.5, .5, channel="music")
    
    scene meadow with fade

    window show
    
    play music "bensound-littleidea.mp3" fadein 3.0
    
    "When Marcus woke up that morning, it was not because he had slept enough.\n"
    
    "The dawn was beautiful, the temperature chilled, the air slightly breezy.\n"
    
    "Indeed, it was a wonderful morning{w=1.0}.{w=1.0}.{w=1.0}.\n
     for sleeping in.\n"
    
    "Well, Marcus was a cat, so it's not all too surprising that he choose to continue sleeping.\n"
    
    "What was surprising was that he was woken up. {w=1.0}\nOr rather, that someone dared to distub his slumber.\n"
    
    window hide
    nvl clear
    
    scene meadow with dissolve
    
    "You see, Marcus's younger brother had gone missing.{w=1.0}\nOr, to be precise: Cat-napped.\n"
    
    "So, as the elder sibiling, he promptly set out and -\n"
    
    "He refused.{w=1.0}\nAndy was old enough to know better, and really,{w=1.0}\n
      what cat is crazy enough to go near water?\n"
    
    "Quite sensible, really, to stay on dry land.\n"
    
    play sound "110393__soundscalpel-com__water-splash.wav"
    
    show splash
    
    ".{w=1.0}.{w=1.0}.{w=1.0}actually, on second thought, maybe he should go and save Andy.{w=1.0}
     \nAnd get back at those fish while he was at it."
    
    stop music fadeout 1.0
    
    window hide
    nvl clear
    
    scene bg black with fade
    
return


label start2:
    
    play music "bensound-clearday.mp3" fadein 1.0
    
    scene beach with fade
    
    window show
    
    "The beach was picture perfect, a stock photograph of a planned vacation. Seagulls crying in the air, waves crashing onto the shore, and golden grains of sand like a plush rug underfoot.\n"
    
    "Under four very big feet, actually.\n\n"
    
    "Despite the beautiful view, Marcus was a bit miffed. Having his sleep disturbed was one thing, his brother cat-napped another. Being splashed by a bunch of flying fish and marsh people was the third thing, 
     which really should have been the end of his list. But noooo he had to go into the water.\n"
    
    "Cats don't have gills! He could drown! Or get eaten! He was a cat, other animals can fear those things, he shouldn't have to!"
    
    window hide
    nvl clear
    
    "But he had to. Closing his eyes, taking a pause, and a deep breath.\n\n\n"
    
    "Marcus opened his eyes and lept in."
    
    stop music fadeout 1.0
    
    window hide
    nvl clear
    
    scene bg black with fade
    
return

label start3:
    
    play music "bensound-funkyelement.mp3" fadein 1.0
    
    scene underwater with fade
    
    window show
    
    "This day was just not going well.\n"
    
    "Giant squid! Another thing that should belong in his belly, and not swimming around trying to kill him.\n"
    
    "His fur was soaked and would require time to dry and groom, and the pressure of the water was heavy!
     {w=1.0}All the seafood was making him hungry, too.\n"
    
    "Despite this, he had to press on. Turning back would unbefitting of him. {w=1.0}How would he cover the embarrassment? Just licking himself wouldn't do at all. 
     {w=1.0}Besides, he could hold the whole situation over Andy's head forever. {w=1.0}Yeah, that would be more than worth it.\n"
    
    "And so Marcus pressed on."
    
    stop music fadeout 1.0
    
    window hide
    nvl clear
    
    scene bg black with fade
    
return

label start4:
    
    scene underwaterboss with fade
    
    window show
    
    "Panic. {w=1.0}Deep bre - can't breathe. {w=1.0}Underwater.\n
     Right. {w=1.0}Lost the shark. {w=1.0}Because of course there would be sharks, nothing can be simple.\n
     There shouldn't be predators bigger than him! {w=1.0}There simply shouldn't be!\n"
    
    "Now where - ah, there he is.\n"
    
    window hide
    nvl clear
    
    scene underwaterboss with dissolve
    window show
    
    play music "bensound-rumble.mp3" fadein 0.5
    
    "At the bottom of the sea, Marcus could just make out a smaller version of himself, casually sitting and watching some blobfish work on a massive weaponized robot blobfish.\n"
    
    "Because Andy had been Cat-napped, clearly.{w=1.0} No, he hadn't been.\n"
    
    "Rather understandably, Marcus was both confused and annoyed. What ex-cat-ly was going on here?\n"
    
    "So, instead of jumping to any conclusions that would lead to a massive battle and probably explosions, Marcus approached and asked what was going on.\n"
    
    "As it turned out, Andy had seen the robot, and went to go watch. {w=1.0}That was alright, war-machines of death and destruction were always worth looking at.\n"
    
    "Also, the blobfish were going to use it to wage war on all land-dwellers and take over in revenge for being constantly made fun of.\n"
    
    window hide
    nvl clear
    
    scene underwaterboss with dissolve
    window show
    
    "{w=1.0}.{w=1.0}.{w=1.0}."
    
    "Oh.\n"
    
    "Yep, totally should have expected that."
    
    stop music fadeout 0.5
    
    scene bg black with fade
    
return

label start:
    
    scene boom with fade
    window show
    
    "And, with a bang, the Blobbot exploded.\n"
    
    "Flailing and thrashing, Marcus and Andy made their way to the surface, and sweet, sweet air."
    
    window hide
    nvl clear
    
    scene bg black with fade
    
return