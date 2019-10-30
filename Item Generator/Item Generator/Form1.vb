Public Class Form1
    Dim Artifact() As String = {"Cryoburst Rod", "Terra Gemstone", "Ethereal Glove", "Grand Master Powerbow", "Zealot's Zephrstaff", "Engraved Golden Sword",
        "Runic Silversword", "The Righteous", "Broken Soul Slayer", "Smited Amulet of Aletoria", "Darkbrand", "Ion Pickaxe",
        "Radiant Mirror Sword", "Doomsword Armor", "Warp Lamp", "Elemental Blade", "Limbosian Grimoire", "The Seal of Fire",
        "Winter's Mistress", "Scorched Heart", "Jar of Wraps", "Sailor's Locket", "Book of the Doomsword", "Neck-wear of Blinking",
        "Diamond Sword Blade", "Ruby Sword Hilt", "Emerald Sword Binding", "Sapphire Sword Handle", "Aquamarine Pyramid", "Immovable Rod",
        "Runic Hourglass", "Rustic Necklace", "Runic Ring", "Headband of the Monolith", "The Master Unlock", "Obsidian Owl Statue",
        "Topaz Wandcap", "Wizard's Scroll", "Amulet of the Dead King", "Genie Lamp", "Runic Tablet", "Divine Amulet",
        "Lucky Locket", "Limbosian Brain in a Jar", "Ra's Scarab", "Heatrock Gauntlet", "Heart Grail", "Oaken Staff",
        "Bag of Holding", "Pulsing Glowrock", "Flamestone Amulet", "Zephr Drop", "Augmenting Ring", "Amulet of Contempt"}
    Dim ArtifactD() As String = {"| - | 5x5 range | A rod crafted by a forgotten Cryomancer, binding a spell of freezing to the rod | The user may turn any water into ice within range | Rolling a 1 causes a misfire, freezing the holder for a round of combat | Holder can deal 8 freezing damage to a target within 2 range |",
        "| 10 + 2d6 terra | 5x5 range | 10 mana | A gemstone that releases a powerful green shockwave from within, knocking anything non-terra back two spaces | Elemental Gem |",
        "| 10 + d6 | 3 range | A glove with an empty gem-slot in the center | When used, the user is flung forward into their chosen target |",
        "| 15 + d4 | 5 range | The user fires a strong arrow from a powerful bow, crafted by Blacketh himself | If the user takes a turn to aim, the next arrow deals an additional +2d4 |",
        "| 4 + 2d4 light | 3x3 range | A white rod with a golden channeler atop, capable of channeling sunlight into increased damage |",
        "| 4 + d6 | 2 range | The user, chosen every two-hundred years, always finds the blade | A formidable blade |",
        "| 5 + d4 | 2 range | The user attacks with an ancient silversword with very old magical runes | When exposed to light damage will glow and deal an additional d4 |",
        "| 5 + d4 | 3 range | A pulsating sword, forged from the purest of Dwarven metals | Used by General Djinn Snow during the Dwarf vs. Gnome War |",
        "| 6 + 2d4 dark damage | 4 range | A blade, containing a tortured soul of a long lost cleric forced to cause only harm for eternity |",
        "| 6 + d4 | 1 range | An amulet crafted by some of the first paladins | Allows the wearer to deal damage to undead when touched by them |",
        "| 6 + d6 dark | 3 range | A weathered dark-arts sword, once held by a territorial Warlock in ancient days | Makes the user immune to dark-arts spells |",
        "| 8 + d6 | 2 range | A pickaxe created from 'star matter' | Created by Andromeda in the early days of the world for the First Elves to mine with | Not affected by skills or features |",
        "| 8 + d6 light | 4 range | When the user is hit by an attack, rolling an 18+ results in the projectile being reflected back at the target | Shimmers like liquid whenever exposed to sunlight |",
        "| 8 AP | A tempered, black-tinted metal armor, worn most often by Doomsword Clan members",
        "| 8 Range | An artifact capable of switching the user and a target within range via teleportation | Target takes the distance switched in damage | ",
        "| 9 + 2d4 | 4 range | A carefully crafted sword made from the Elemental Gems | When an attack is successful, the user may pick the damage type of the sword |",
        "| A book detailing The Limbo, including it's history and magical lessons | The book draws the reader in each chapter until they lose themselves within the book |",
        "| A fiery seal that, when activated, grants the holder immunity to fire for two turns | Holder can deal an immediate 10 fire damage to a single target within 2 range | Three turn cooldown |",
        "| A frozen cylinder with a piece of ice on each side | The ice reacts when kissed, with one side creating a Sudden Blizzard around the user and the other disabling the weather |",
        "| A gemstone once used by a Flameweaver in the ancient past to defeat a horde of Terrabounds | Engulfs the user in flames, allowing them to deal an additional +2d4 fire damage to their next attack | Elemental Gem |",
        "| A jar of tightly-packed bandages | When placed on a skeleton, the bands wrap the skeleton in rags, raising them as an ally for three turns before turning to ash |",
        "| A locket that, when opened, releases a wave of water | Releases the wave in a 5x5, restoring Hydromage stamina by 7 |",
        "| A moderately sized book detailing the Doomsword family lineage | Covered in a layer of caked mud after being dropped by Thrall Doomsword |",
        "| A necklace that, when worn, empowers the wearer to extend their blink range by two | Enchanted with 'Blink' by a powerful Gnomish Bard |",
        "| A piece of the Elemental Blade, representing the Air element |",
        "| A piece of the Elemental Blade, representing the Fire element |",
        "| A piece of the Elemental Blade, representing the Terra element |",
        "| A piece of the Elemental Blade, representing the Water element |",
        "| A relic from an ancient warrior, capable of crafting almost anything out of nearby water | Releases a shockwave of water inflicting 8 + 2d6 drowning damage in a 7x7 range | Elemental Gem |",
        "| A rod contain an enchanted axis, allowing the rod to remain stationary unless acted upon by immense force | Locks in place with a simple spoken word chosen by the holder |",
        "| A rusty hourglass found around Boldwood | Capable of being enchanted with high-level arcane arts |",
        "| A rusty necklace found around Boldwood | Capable of being enchanted with high-level arcane arts |",
        "| A rusty ring, polished and buffed for a reflective shine | Capable of being enchanted with high-level arcane arts |",
        "| A silver headband with a large, central stone | When worn, the user is given a vision of a large slab of stone surrounded by twisting bodies | Gives the user an additional +d4 to melee attacks |",
        "| A skeleton key for all doors save those which are bound with magical properties |",
        "| A small statue of an owl crafted from obsidian, found on the Coast of Salacia, Hundlebovia | The statue has the natural features of an owl with striking blue-gem eyes set in place |",
        "| A topaz cap made to fit upon many spell-casting objects | Adds +2 to magic damage |",
        "| A torn scroll that allows the holder to repick two spells |",
        "| A worn amulet, once worn by a powerful king | Empty jewel slots begin to glow when near an undead target, allowing the user to control one undead for combat | 2d6 |",
        "| A worn lamp that, when rubbed, releases a shackled Genie capable of granting a dying wish before dissipating | Wishes do have a ceiling on their ability |",
        "| Adds +5d6 to the next healing ability used | Shatters when read | Created in Thei Cai and smuggled out of the city |",
        "| Allows the holder to use their feature twice per combat but can only be used three times |",
        "| Along with 20, the wearer may pick another number to be a critical success |",
        "| An active brain inside a green-tinted jar | Allows the holder to command undead within 8 range |",
        "| An artifact passed down to Ra from his father, and his father before him | Enables Ra to have absolute mental and physical resolve, never caving to pressure or influence |",
        "| An enchanted gauntlet that allows the wearer to hold warm objects without being harmed |",
        "| An enchanted item once used by a cruel mistress | Beings that drink from this grail must roll to resist becoming a charmed ally for two turns | If charmed, the owner of the grail may give commands on their turn to the enthralled individual |",
        "| Bound to its holder by blood | Allows the user to refresh a single feature to be used two times per combat | Shatters on a 1 |",
        "| Incredibly rare, mystical items, prized often for accessing infinite storage | Items may be removed by anyone who possesses the bag |",
        "| When placed on the ground, a 5x5 zone of double damage activates | Each time its used a small bit of light escapes the rock, dimming it | Turns into an Empty Glowrock after 3 uses |",
        "| Worn by dwarves to prevent the constant heat and work from driving them mentally insane | Prevents the wearer from mental attacks |",
        "| A relic uncovered from a collapsed temple, used to throw a target up to 6 spaces away | 9 + d6 air per tile | 5x5 range | Elemental Gem |",
        "| 2d4 | 2 range | A ring, crafted by a Flameweaver, Terrabound, Paladin, Psychic, and a Hydromage atop Mt. Towdive | Applies either fire, ice, water, lightning, or terra |",
        "| Allows the holder to maintain the stamina cost of a single skill to 1 as long as the amulet is worn"}
    Dim Common() As String = {"Flashbomb", "Condensing Buckler Shield", "Arcane Pistol", "Elven Spellblade", "Fishing Net", "Potion Flinger",
            "Dagger", "Fluid Greatsword", "Flame Blade", "Memeium Staff", "Pickaxe", "Memeium Nun-chucks",
            "Whip", "Light Crossbow", "Blunderbust", "Double Arrow ", "Longblunder", "War Axe",
            "Short Sword", "Battleaxe", "Voidcane", "Cobalt Sword", "Stained Silver Sword", "Longstaff",
            "Rusty Six-Shot", "Rat, Tat, Tat Revolver", "Harming Potion", "Cobalt Rifle", "Cobalt Arrow", "Valor Holystaff",
            "Scimitar", "Cobalt Longstaff", "Assassin Dagger", "Rusty Armor", "Cobalt Shield", "Memeium Shield",
            "Stun Whip", "Healing Potion", "Drum", "Harp", "Flute", "Bloodhook Claws",
            "Arcane Cobalt Blade", "Darksilver Sword", "Rapier", "Hardened Battleaxe", "Forged Silver Sword", "Revenge Waraxe",
            "Dwarven Handaxe", "Scythe", "Katana", "War Hammer", "Swornscythe Hasta", "Darksilver Shurikens",
            "Axeblade", "Mage's Manabow", "Javelin of Fireball", "Polished Longbow", "Iron Spear", "Crossbow",
            "Frenzy Disk", "Sun Flail", "Cobalt Armor", "Armor of the Sworn", "Boneplate Armor", "Knight Shield",
            "Shatterscale Shield", "Memeium Armor", "Cobalt-Weaved Gloves", "Broad Pickaxe", "Longsword", "Golden Sword",
            "Mechanical Sword", "Cobalt Pike", "Sea-salt Bomb", "Harpoon", "Spear", "Reforged Shuriken",
            "Compact Rifle", "Combat Bow", "Greatsword", "Bloodiron Armor", "Iron Armor", "Dwarven Plate Armor",
            "Bolstered Cobalt Armor", "Tower Shield", "Enlightened Armor", "Golden Spear", "Giant Shield", "Talkative Backpack",
            "Wireframe Basket", "Bottle of Wine", "Candle of Truth", "Scroll Case", "Mineshire Brand Cigar", "Clockdial Mirror",
            "Lantern", "Cobalt Chunk", "Fungari Slime", "Carved Bone", "Pocket Leash", "Tribal Drum",
            "Whetstone", "Opaque Glass Gem", "Levitating Hat", "Sturenbrew", "Sweatband", "Jar of Honey",
            "Cattail", "Welden's Bag of Temporary Displacement", "Bag of Books", "Gambler's Dice", "Charcoal", "Bread",
            "Rope", "Nocturnal Pocketwatch", "Cheese", "Silver Feather", "Local Scope", "Sundial",
            "Flint and Steel", "Stamina Potion", "Tent", "Oil", "Inn Ticket", "Vial of Ill-Tempered Liquid",
            "Vial of Treeling Sap", "Glove of Holding", "Dwarven Grappling Hook", "Weighted Brace", "Weighted Ankle Braces", "Spiked Helmet",
            "Whale Blubber Armor Layer", "Backpack", "Magic 8 Ball", "Pocketwatch", "Oversaturated Gelatinous Orb", "Enchanted Obese Belt",
            "Metal Vial", "Quarterstaff", "Stalker Dagger", "Scrapbust", "Phantom Gauntlet", "Enraging Potion",
            "Octovoid Slime", "Quiver", "Illyn", "Dented Bronze Helmet", "Magical Swamp Mud", "Coconut",
            "Beer", "Wrist Crossbow", "Forever-Knot Shoes", "Sacred Staff", "Smoke Bomb ", "Invisible Ink",
            "Transparent Glass Gem", "Saddle", "Telescope", "Haggler Gloves", "Forged Dwarven Helmet", "Ironhide Bracer"}
    Dim CommonD() As String = {"| - | 4 range | When thrown, anything within the 3x3 AOE is blinded for a turn, unable to attack |",
            "| - damage | - range |  The shield protects the user against incoming damage up to 5 (10 or higher) |",
            "| - damage | - range | A powerful weapon carried by Wizards and Sorcerers, alike | Rolling a 20 allows the fired spell to gain +2d4 |",
            "| - damage | 3 range | Halves mana cost of spell | A strong blade meant for battle, fires spells through it at a reduced mana cost | Rolling lower than a 7 breaks the blade |",
            "| - damage | 4 range | When thrown on a target, they have to roll to escape |",
            "| - damage | 6 range | The user fires a potion with greater range and accuracy |",
            "| 1 + 4d4 | 1 range | The user attacks the target with a sharp dagger |",
            "| 1 + d4 | 1 range | When wet, the dagger turns into a greatsword | 6 + d6 | 3 range |",
            "| 1 + d4 | 2 range | A flaming blade, deals 1 fire damage per turn for five turns |",
            "| 1 + d6 | 5 range | The user swings a memeium staff, summoning a rare frog | The frog has 20 stamina and only summons a new one when the previous dies |",
            "| 2 + 2d4 | 1 range | A basic pickaxe, capable of breaking open rocks and making quick work of softer stones |",
            "| 2 + d4 | 2 range | Icicle | Fireball | Lightning Bolt | Stonehand | Augmentation is permanent |",
            "| 2 + d4 | 4 range | A leather whip made from animal hide | When the roll is +15, the user may catch an appendage of the enemy with the whip |",
            "| 2 + d4 | 5 range | A light-weight crossbow with a fine finish giving it an appealing look | Rather cheap but gets the job done |",
            "| 2 + d4 | 5 range | A simple pistol, carried by both pretentious nobles and tough gunslingers, 'just in case' |",
            "| 2 + d4 | An arrow that splits in half, hitting two possible targets | 15 arrows |",
            "| 2 + d6 | 5 range | User fires a blunderbust at the target |",
            "| 3 + d4 | 2 range | A common War Axe, found among both the poor and wealthy | Firm wooden handle connected to a cobalt-tipped axehead |",
            "| 3 + d4 | 2 range | A short sword, held comfortably by almost all sizes |",
            "| 3 + d4 | 2 range | A strong axe, most often spotted in fierce combat  | Can't be duel-wielding |",
            "| 3 + d4 | 2 range | Encases the user in a Void Shield, protecting them from damage | Vanishes on a 1-5 |",
            "| 3 + d4 | 2 range | The user swings a cobalt blade at the target |",
            "| 3 + d4 | 2 range | The users swings a silver sword at the target | Deals additional 2d6 to undead |",
            "| 3 + d4 | 4 range | An etched longstaff carried by Monks and elders alike | Useful for support or attacking a target | Rolling 20 allows for a sweeping attack on a targets feet |",
            "| 3 + d4 | 4 range | The user fires a rusty pistol at a target, rolling 1-3 breaks down the pistol |",
            "| 3 + d4 | 4 range | When shot, a rat flies towards the target | The rat either dies or scurries off |",
            "| 3 + d4 | 4 range | When thrown, anything within the 3x3 AOE is harmed |",
            "| 3 + d4 | 5 range | Passes through the target, hitting anything lined up behind it |",
            "| 3 + d4 | A normal arrow crafted from cobalt | 20 arrows |",
            "| 3 + d4 light | 3 range | A weapon unveiled at the Cowboy Bang Bang Gunshow CLX | A staff powered by a small power supply in its base, allowing light damage to be send outward |",
            "| 3 + d6 | 3 range | A curved blade, held in one hand |",
            "| 3 + d6 | 3x3 range | The user swings a cobalt staff around in a 3x3 circle |",
            "| 3 + d6 dark | 1 range | A dagger worn by thieves, bandits, and worse | Easily concealable beneath clothing | Tip dipped in volatile poisons, secreted from venomous beasts |",
            "| 3 AP | A rusted, old armor, worn by bandits and desert dwellers | Breaks after being hit five times | Not effective while wearing other armor |",
            "| 3 defense | 1 range | Rolling higher than 10 successfully blocks 3 incoming damage by lifting the shield to defend yourself |",
            "| 3 magic defense | 1 range | 1 mana | Rolling higher than 10 successfully blocks 3 incoming magic damage |",
            "| 3 range | The user hits a target with the stun whip, causing the enemy's muscles to constrict and prevent them from moving |",
            "| 3 stamina + d4 | 4 range | When thrown, anything within the 3x3 AOE is healed |",
            "| 3x3 range | +1 damage zone | A crafted drum used by Bards across the realm |",
            "| 3x3 range | +1 stamina zone | +1 mana zone | A fine-tuned instrument crafted from the wood of a tall Fern tree | Played by nimble-fingered individuals |",
            "| 3x3 range | +1 stamina zone | A flute crafted from fine wood, seen often with traveling Bards |",
            "| 4 + d4 | 1 range | Bloody claws originating from deep underground | Can be used to climb surfaces |",
            "| 4 + d4 | 2 range | 2 mana | The user, a magic user, swings a magic-infused blade at a target, causing an aqua aura around the user |",
            "| 4 + d4 | 2 range | The user attacks a target with a sword made of Darksilver, imported from the Emperor in Hundlebovia |",
            "| 4 + d4 | 2 range | The user attacks with a rapier | Ignores armor AP |",
            "| 4 + d4 | 2 range | The user cleaves a battle axe down on the target |",
            "| 4 + d4 | 2 range | The users swings a silver sword at the target | Deals additional d6 to undead |",
            "| 4 + d4 | 2 range | When attacked, this waraxe floods the holder with anger, allowing them to attack in retaliation against the target |",
            "| 4 + d4 | 3 range | A dwarven-forged handaxe, able to be used to climb surfaces |",
            "| 4 + d4 | 3 range | A stained blade with a sharpened point | Covered in a jaded surface to ensure it digs into the chosen target |",
            "| 4 + d4 | 3 range | The user swings a sharpened katana at the target, able to cleave off limbs on a 20 | Rolls over 10 allow a second swipe for half damage | ",
            "| 4 + d4 | 3x3 range | A large hammer, swung by those capable of carrying it | Inflicts damage in a moderate area | ",
            "| 4 + d4 | 4 range | A long, spear-like object with a decorative topping | Typically held by the sworn, spotted pillaging caravans across the lands |",
            "| 4 + d4 | 4 range | Crafted by the Emperor's empire, these Darksilver shurikens are razor-sharp | Thrown individually at a single target |",
            "| 4 + d4 | 4 range | Large, intimidating blades carried by those capable of shouldering the heavy weapon |  ",
            "| 4 + d4 | 5 range | A bow enriched by magic, capable of firing blue-tipped arrows towards a target | Arrows pass through natural occuring things (trees,bushes) |",
            "| 4 + d4 | 5 range | A javelin enchanted with the spell 'Fireball' | When thrown towards a target, the javelin will convert into a fireball |",
            "| 4 + d4 | 5 range | A smooth-looking bow, capped with custom tips made of gold | The fine-tuned string enables further arrow-launching than regular bows |",
            "| 4 + d4 | 5 range | An iron spear, created for use of ranged infantry |",
            "| 4 + d4 | 5 range | The user fires a heavy bolt towards the enemy |",
            "| 4 + d4 | 6 range | A white disk with an orange glow coming from it's in-set center | When thrown, the disk will travel the full range before returning to the user |",
            "| 4 + d6 fire | 2 range | A large flail crafted by Dwarves, able to be used as brute force and to inflict fire damage on a target |",
            "| 4 AP | A basic, blue-tinted metal armor, worn by soldiers and nobles alike | Not effective while wearing other armor |",
            "| 4 AP | Armor worn by those sworn to an exile of some fashion, often seen at gladiator fights |",
            "| 4 AP | Armor, crafted from multiple, interweaving layers of bones | Not effective while wearing other armor |",
            "| 4 defense | 1 range | Rolling higher than 10 successfully blocks 4 incoming damage by taking cover behind the shield |",
            "| 4 defense | 2 range | Rolling higher than 10 successfully blocks 4 incoming damage by lifting the shield to defend yourself |",
            "| 4 MP | A purple-pink tinted metal armor, worn by sorcerer's looking for a magical boost | Not effective while wearing other armor |",
            "| 5 + d4 | 1 range | The user, a monk or other physical class, hits a target with strong cobalt gloves |",
            "| 5 + d4 | 2 range | Most commonly found in Delvoria in the possession of cave dwarves |",
            "| 5 + d4 | 2 range | The user swings a longsword at the enemy |",
            "| 5 + d4 | 3 range | A forged sword from a mix of alloys, refined to the shape of a piercing blade |",
            "| 5 + d4 | 3 range | A mechanical sword with many rotating gears to provide a forceful swing upon a target |",
            "| 5 + d4 | 3 range | The user attacks the target with a cobalt pike |",
            "| 5 + d4 | 3x3 range | A homemade bomb, packed tightly with sea-salt | When detonated, all targets within range roll for going blind for a turn |",
            "| 5 + d4 | 4 range | Fires a harpoon at the target, a rope connects to the harpoon |",
            "| 5 + d4 | 4 range | The user flings a spear at a target, must retrieve the spear |",
            "| 5 + d4 | 4 range | The user throws a claw-covered shuriken at a target, inflicting moderate damage |",
            "| 5 + d4 | 5 range | A rifle, able to be folded up and put away in a backpack | Covered in a silver dust, stuck to the gun |",
            "| 5 + d4 | 5 range | When the user spends a turn setting up, the next attack from the bow does an additional d4 damage and the range is increased to 7 |",
            "| 5 + d6 | 2 range | A large blade carried on the back of strong-willed individuals | Rolls under 5 cause the user to catch their breath their next turn |",
            "| 6 AP | A red-tinted metal armor, dyed red in blood on active battlefields by Orcs | Not effective while wearing other armor |",
            "| 6 AP | A silver-tinted metal armor, worn by Ironside humans capable of carrying the immense weight | Not effective while wearing other armor |",
            "| 6 AP | A strong set of armor forged by dwarven blacksmiths | Unable to be upgraded due to the crafting method used for producing the armor's strength |",
            "| 6 AP | A blue-tinted metal armor, patched and upgraded over time to a more refined style | ",
            "| 6 defense | 2 range | Rolling higher than 10 successfully blocks 6 incoming damage by heaving the shield between the attack and yourself |",
            "| 6 MP | A fancy armor, taken by the magical likes of a new sorcerer |",
            "| 7 + d6 | 5 range | The Emperor, Septyr, strikes a target with a golden spear, attacking quickly and deadly |",
            "| 8 defense | 1 range | Rolling higher than 10 successfully blocks 8 incoming damage by heaving the shield between the attack and yourself | User must spend next turn resting |",
            "| A backpack that when worn will discuss random topics with the wearer |",
            "| A basket crafted loosely from scrap wire, providing an additional inventory space when worn | Breaks when the user is hit with more than 15 damage at once |",
            "| A bottle of fine wine, capable of restoring 2 stamina when drank | Gallon of Ale is 20 bottles of wine, 40 stamina |",
            "| A candle topped with an engraved topper, showing an elven man's face | Beings within the 5x5 area around the candle cannot lie when the candle is lit | 2 Use item |",
            "| A case with a nametag that says: 'Property of Super Wizard, Gubba the Eleventh' | Can safely seal a variety of scrolls, documents, or any other parchment in any environment |",
            "| A cigar packed full of mineral ore | Smoked by the Dwarves located around Delvoria | Popular among dwarves |",
            "| A clock with a strange ability | When the dials are set to a specific time within the day, the holder is shown themself at the input time |",
            "| A common lantern, capable of luminating a 5x5 area of light around the user | Needs oil to operate | Starts with x1 Oil |",
            "| A common metal, capable of being crafted into many forms by most blacksmiths |",
            "| A dangerous slime leaked out of Fungari growths in dank climates | Gives a seizure to those who ingest the pasty mixture |",
            "| A decoratively carved bone, originally from a large, furry creature |",
            "| A device created by an Elven father annoyed at his pet Dex wandering away | Any target locked into the leash is unable to go further than 5 range away from the holder |",
            "| A drum made from hide stretched across the top and bottom | Decorated with tribal designs | Increases ally damage within a 7x7 area by four during the turn |",
            "| A fine stone made in abundance at blacksmith stands across the Pathosrealm | Allows a sword to deal +2d4 damage on its next attack | Single-use Item |",
            "| A gem capable of holding a soul | Contains a being's soul |",
            "| A hat that floats above the wearer's head | Enchanted by a Sorcerer but refuses to touch heads |",
            "| A heavy bottle of dwarven-brewed substance | One simple sip will make non-dwarfs intoxicated |",
            "| A homemade sweatband, allowing the user to use weapons for 1 less stamina cost |",
            "| A jar of ancient honey, with several insects inside it |",
            "| A long plant, commonly found near water | Restores 2 stamina when eaten |",
            "| A matching pair of small bags, capable of transporting items over any distance | ",
            "| A messy bag of books, typically found near related areas of information |",
            "| A pair of rigged dice, once owned by a legendary gambler | Can be used to win games against NPCs |",
            "| A piece of burnt, treated wood | Used as fuel |",
            "| A piece of lightly toasted bread | Adds 2 to stamina when eaten |",
            "| A piece of rope, used by everyone from adventurers to farmers for a variety of uses | 2 range |",
            "| A pocketwatch that only works at night | Used by Dwarves in mines far below the surface to tell if it is day or night |",
            "| A product made primarily by Gnome farmers | Restores 1 stamina when eaten and often regarded as delicious |",
            "| A reflective feather found underneath a rare Silverbelly's migration path | Can be sold for 25 Illyn |",
            "| A scope worn over the eye of an individual | When worn, allows the user to know of any enemy within a 5x5 range around themselves |",
            "| A shadow is cast upon the ground, showing a clear indication of where the sun is at |",
            "| A simple piece of flint and metal, used to ignite fires with ease |",
            "| A standard bottle's worth of regenerative liquid, capable of restoring 5 stamina to a single target |",
            "| A temporary shelter | Takes two turns to set up or instant during a break | Allows those that rest within to gain back their stamina |",
            "| A thick, dark substance with a foul smell | When applied onto a surface, the area becomes rather slippery and flammable | Useful as fuel for a variety of creations |",
            "| A ticket that, when given to a tavern owner, will allow the holder to stay overnight for free |",
            "| A tightly-packed vial of a multi-colored liquid, gathered by scavengers over time | Used by those lost in deserts to survive days at a time | ",
            "| A vial containing a thick, bubbly mixture sticking to all sides of the container | ",
            "| A white glove capable of holding a seemingly infinite amount of hands | Resulted from a failed Wizard's experimental spellcasting |",
            "| Able to be thrown across spaces up to five tiles wide | Tougher than normal grappling hooks | If the wire is attempted to be cut or break, it instead retreats back into the hilt of the hook |",
            "| Adds +d4 to melee attacks for non-magic classes | Reduces movement speed by 1 if the wearer is not melee |",
            "| Adds +d4 to melee attacks for non-magic classes | Reduces movement speed by 1 if the wearer is not melee |",
            "| Adds an additional +3 to charge damage | Head is protected from heavy damage unless against a 20 |",
            "| Adds an additional 2 AP to the armor being worn by the user | Slows non-seaswag creature's movement speed by one |",
            "| Adds an additional 3 spaces of inventory | Equip to an open wearing slot |",
            "| An 8-ball created by a leading team of Gnome inventors | Gives those who shake it an answer from a d6 submerged in liquid |",
            "| An enchantable watch able to be put in the pocket of whoever holds it | Tells the time to whoever looks into it |",
            "| An extremely wet orb, carved from a Gelatinous Cube | The orb reacts to the cube's environment and vise versa |",
            "| An interesting piece of cloth once enchanted to grow with each use by an obese Wizard |",
            "| Can't be broken from dropping | Useful for replacing potion bottles |",
            "| d4 | 2 range | A wooden staff, often carved, used by magical users to cast spells and deal low amounts of melee damage |",
            "| d4 damage | 1 range | A very small dagger, feels like a needle when used on a target | Barely noticeable but after five turns deals 2 poison damage for three turns |",
            "| d4 for each cog/bolt the tinkerer has in their inventory | 4 range |",
            "| d6 dark | A gauntlet that, when is rolled over 10, phases away and attacks the closest target to the wearer | On rolls below 11, the gauntlet tightens on the hand of it's host, inflicting d6 dark |",
            "| Damage doubles, but the party is viewed as hostile |",
            "| Extremely slippery, delicious, and flammable | Harvested by scraping the underside of an Octovoid |",
            "| Holds up to 60 arrows at a time | Two can be worn at a time ",
            "| Ill-een | New currency, created for the additional continents by the Illyrians with the perfect amount created to prevent inflation or depression |",
            "| Raises AP by one and prevents being decapitated |",
            "| Restores 2 stamina when rubbed on a goblin |",
            "| Restores 5 stamina |",
            "| Restores 5 stamina | Drinking more than two in one combat causes the drinker to be intoxicated |",
            "| Roll d4 | 5 range | The user fires a small bolt towards the target |",
            "| Shoes that fit any foot and can't be removed until the host's heart stops |",
            "| The user binds one spell with a mana cost less than 10 to the staff, allowing the spell to be cast for free | Shatters if the holder rolls a 1 |",
            "| The user throws a bomb that detonates in a 3x3, filling it with smoke | Can be thrown up to 3 range | ",
            "| Turns whatever it touches invisible for five minutes |",
            "| Used to store souls within | Often used as decoration around households across Elmorvia |",
            "| When put on a creature, the creature has to roll to resist being trained and subdued |",
            "| When used, the user can see 10 range in the direction they look through the telescope |",
            "| When worn, the user is more likely be to be called out by guards | When attempting to buy something, they may drop the price by at most 15 Illyn |",
            "| Worn atop your head | Adds an additional one AP to the current armor being worn | AP cannot exceed 10 |",
            "| Raises the wearer's AP by one | Single-use item | AP cannot exceed 10 |"}
    Dim Uncommon() As String = {"Division Potion", "Enchanted Robes ", "Chalice of Health", "Gearblast Cannon Mk. I", "Fifth Chain Hammer", "Whale Oil",
            "Steel Armor", "Instant Chainmail", "Bulletpage Book", "Turret-Buster Mk. IV", "Knuckles of Ugana", "Cobalt Claws",
            "Direshark Scaleblade ", "Cutlass", "Thei-Order Scimitar", "Gios Gauntlet Mk. II", "Cobalt Mace ", "Krypopper",
            "Zako's Fist", "Thunder Strike Hammer", "Scoped Tinkered Cobalt Crossbow", "Duking's Crystal Zeminizer", "Mechanical Boltlauncher", "Phantom Blade",
            "Trung-gun Mk. IV", "Blunderbarrel", "Dex Gauntlets", "Warblade", "Dwarven Forgehammer", "Skullcrusher Hammer",
            "Grand Runemaster Blade", "Torcher", "Dwarven Waraxe", "Firebomb", "Chargebow Mk. IV", "Acid Rain Potion",
            "Warblade Handaxe Grappling Hook", "Pankos Pulser", "Bomb", "Shouldergear Cannon", "Gem Owl Talon", "Brass Knuckle",
            "Bloodforge Blades", "Nemesis' Fan", "Quiver-Plate", "Bear Trap", "Flint's Refined Cobalt Armor", "Bear Trap on a Whip",
            "Fusionic Whip", "Golden Octovoid Hammer ", "Blade of the Forgotten King", "Scoped Bolt-Rifle ", "Runic Armor", "Bag of Zebraphant Milk",
            "Summoned Book", "Rune-Covered Flute", "Artificial Mana Crystal", "Cube of Appetite", "Weapon Sling", "Ancient Runic Blade",
            "Embermane Dust", "Gold Feather", "Fusionic Charm", "Warrior's Ale", "Pulsing Ruby", "Death's Wish",
            "Oresa's Ointment", "Brewed Elixir ", "Greater Stamina Potion", "Skullgap Satchel", "Shrimpstaff", "Octovoid Tooth",
            "Storm in a Bottle", "Mana Rocket", "Pendent of Solitude", "Cracked Enchanted Pendent", "Quickening Potion", "Tainted Blood",
            "Greater Mana Potion", "Ring of Lying", "Cyborg Arm", "Bound Palm Stone", "Scale of Xennudi", "Elemental Waters",
            "Stone of Inquiry ", "Bubbling Shining Holy Regenerative Herb ", "Indestructible Spoon ", "Valgarian Runestaff ", "Recharge Potion ", "Limbosian Talisman ",
            "Enchanted Book", "Donkey King Heart", "Monocle", "Damaged Ring of the Salt", "Pankos Plaster", "Arcane Rune",
            "Vase of Thirst", "Regal Tophat", "Electron Core", "Dungeoneer's Riflesight", "Orb of Truth", "Dwarven Pipe",
            "Elastic Rope", "Magic Mirror ", "Coin of Privacy ", "Powercuff Heels ", "Informative Goblin Staff ", "Tattletale ",
            "Shocksonic Boots", "Compass", "Paladin Necklace", "Armor Bracer", "Regenerative Staff", "Orb of Stabilization",
            "Puppeteer's Booklet ", "Cookbook ", "Enchanted Toolbox ", "Memeium-woven Robe", "Bag of Fiery Flames ", "Graced Boots ",
            "Fictional Prince's Cane", "Butterfly Dust", "Silky Gem", "Kinetic Thruster", "Shielding Potion", "Cobalt Scope",
            "Shadow Cloak", "Ascension Cloak", "Illyrian Wine", "Well-Cut Diamond"}
    Dim UncommonD() As String = {"| - damage | 4 range | When thrown, anything within the 3x3 AOE splits in half with half the full stamina and mana of the user | Can only be used by alchemists |",
            "| +10 mana | Fine clothing, enchanted to bestow additional mana to its wearer |",
            "| +15 stamina | A fancy chalice with cobalt detailing, capable of restoring 15 stamina instantly |",
            "| 10 + d6 | 10 range | An upgraded cannon unveiled at the Cowboy Bang Bang Gunshow CLX | Fires a collection of gears as shrapnel when roll is 15+ |",
            "| 10 + d6 | 3 range | A carved hammer engraved with Dwarven markings signifying rank | Held by the Fifth Chain, Protectors of the King | ",
            "| 10 + d6 fire | 3x3 range | When put on a target and ignited, the target is damaged immensely by whale oil | Flames are extinguished upon the target taking damage |",
            "| 10 AP | A dark silver-tinted metal armor, worn by strong warriors |",
            "| 10 AP | Chainmail enchanted with the ability to enclose itself around it's holder | Remains active for two turns | Three turn cool down |",
            "| 12 damage | 4 range | A book equipped with two powerful bullets | Each bullet tears more of the binding, breaking after two shots |",
            "| 15 + 2d6 shock | 5x5 range | A device that, upon setting up, will detonate upon receiving electric input, destroying turrets or causing serious damage to electric devices within range |",
            "| 2 + 2d4 | 1 range | A pair of red-laced knuckles exported from the town of Ugana, Gnovia |",
            "| 3 + 2d4 | 1 range | The user, a monk, swings his cobalt claws at a target |",
            "| 3 + 2d4 | 2 range | The target swings a blade made of direshark scales towards a target |",
            "| 3 + 2d4 | 3 range | The user attacks the target with a cutlass |",
            "| 3 + 2d4 shocking | 3 range | A curved blade, forged within Thei Cai by the Thei Souls of the Sand | Upon a successful attack, the weapon is charged 1/5 | Upon a full charge, an additional +2d4 shock damage arches towards the target from the blade |",
            "| 3 + d6 | 2 range | A weapon unveiled at the Cowboy Bang Bang Gunshow CLX | A heavy gauntlet that fires outward when used, fires twice when roll is 12+ |",
            "| 4 + 2d4 | 2 range | The user swings with a cobalt mace, slowing a target for one turn to three movement |",
            "| 4 + 2d4 | 3 range | A weapon unveiled at the Cowboy Bang Bang Gunshow CLX | A pistol created by Krykold that is capable of firing in quick succession |",
            "| 4 + 2d4 fire | 2 range | A flaming gauntlet worn by those used to the flames and heat | If used more than two turns in a row will become unstable |",
            "| 4 + 2d4 shock | 3x3 range | A strong hammer. When swung, a 3x3 area is hit by thunder, dealing minor to severe damage |",
            "| 4 + d4 + d6 light | 8 range | The user fires an arrow or bolt through a ring attached at the end of the barrel | Ignited when shot, dealing an additional +d6 fire |",
            "| 4 + d4 shock | 3 range | A weapon unveiled at the Cowboy Bang Bang Gunshow CLX | A device that fires shocking tentacles into nearby crystals, allowing the user to detonate up to three for 5d4 each |",
            "| 4 + d6 | 4 range | A bow-like tinker creation | Capable of launching bolts across a limited range |",
            "| 4 + d6 dark | 3 range | A mumbling blade, whispering dark secrets to those willing to hold it | ",
            "| 4 + d6 shock | 4 range | A weapon unveiled at the Cowboy Bang Bang Gunshow CLX | Fires a projectile covered in a shocking layer of electricity |",
            "| 5 + d6 | 1 range | A short barreled shotgun, capable of inflicting critical damage with ease | Historically used to subdue trespassing Dextros |",
            "| 5 + d6 | 1 range | Gauntlets created from a dead Dex, used by some in gladiatorial combat | ",
            "| 5 + d6 | 2 range | An intricate blade covered in small spaces for tearing enemy flesh from their bones | ",
            "| 5 + d6 | 2 range | Often used by dwarves at forges, capable of withstanding incredible temperatures | Remains cool to the touch despite the heat it is in |",
            "| 5 + d6 | 2 range | The user, an orc, swings a large hammer down on a target, dealing massive damage |  Drains stamina quicker than most hammers due to it's size |",
            "| 5 + d6 | 3 range | A chiseled stone blade with hints of a metal core peaking through the stone | Generates a rune for the user when used successfully |",
            "| 5 + d6 | 3 range | The user blows flames towards a target, using Oil as fuel | ",
            "| 5 + d6 | 3 range | The user dives at the target, taking a large swing at them |",
            "| 5 + d6 fire | 4 range | When thrown, anything within the 3x3 AOE is engulfed in fire, dealing an additional +d6 of damage each turn to those in the fire |",
            "| 5 + d6 shock | 5 range | A weapon unveiled at the Cowboy Bang Bang Gunshow CLX | A bow that fires a charged arrow, releasing a pulse upon making contact |",
            "| 5d4 over 5 turns  | 4 range | When thrown, anything within the 3x3 AOE is affected by poison for five turns |",
            "| 6 + 2d4 fire | 3 range | Can be used to climb surfaces | Up to five tiles wide | Tougher than normal grappling hooks, retracts when attempting to be broke |",
            "| 6 + 2d6 | 3x3 range | Pankos' handmade weapon, capable of releasing a built-up electric charge in an AoE | Damage is doubled when the target is wet | Hidden in his pegleg, every step charges it a tiny bit |",
            "| 6 + 2d6 fire damage | 3x3 range | An explosive contraption made to create devastation in a limited area |",
            "| 6 + d4 | 5 range | The user, an orc, mounts a cannon on their shoulder, firing towards a target | User gets knocked onto their back |",
            "| 6 + d6 | 1 range | A talon found near Oke | Covered in a blueish hue, pulsating when touched by a magic user |",
            "| 6 + d6 | 1 range | Primitive fighting utensils, utilized in close-quarters combat with high-risk, high-reward |",
            "| 6 + d6 | 3 range | Two blades, often seen paired together with Vampires, used in rituals and other grotesque experiments | Two hands required |",
            "| 6 + d6 dark | 4 range | A small fan with red and yellow patterns, capable of releasing a sudden flash of blades into a target |",
            "| 6 AP | A bronze tinted medal armor, worn by those tight on money | Not effective while wearing other armor | Provides the wearer with 60 additional ranged weapon ammo slots |",
            "| 7 + d4 | 3x3 range | A trap, built to capture large game across all terrain | Takes a turn to initially set up the trap |",
            "| 7 AP | Decorated with Flint's personal sigils | Worn by those engaging in risky combat with gold to spare |",
            "| 8 + d4 | 4 range | A decent size trap, attached to a trusty whip |",
            "| 8 + d6 | 3 range | The user grips a target with the Fusionic Whip, causing severe damage | Partnered with the Fusionic Charm |",
            "| 8 + d6 | 3x3 range | The user swings a large hammer down on an AOE, has to recover the next turn (but still can move) |",
            "| 8 + d6 | 4 range | A blade once held by the very temporary King of Kerp, a legendary Gnome folk hero |",
            "| 8 + d6 | 5 range | The user fires a heavy bolt towards the enemy from a great distance |",
            "| 9 MP | A brown, dull appearing pelt armor, heavy like a sack of brick | Reduces movement speed by one during combat |",
            "| A bag of lukewarm milk that when drank induces natural camouflage | Effect lasts 2 turns |",
            "| A book that pulls a users spell and binds the spell to the pages of the book | Book cannot attack |",
            "| A carefully carved flute that summons three snakes, each dealing 2d4 | The user may also turn into a snake and communicate with the snakes at will |",
            "| A charged mana crystal that grants it's holder an artificial mana pool of 15 mana | Prone to cracking when overused |",
            "| A cube, small enough to be held by a Gnome, that causes the holder to feel a sensation of hunger, with the effect increasing when the holder begins to eat |",
            "| A custom-crafted holster fit for any race, from Highland Elves to Seaswag Goblins | Allows the user to have an additional weapon slot |",
            "| A decorative, rustic blade carried by Runemasters | When broken, reveals a Grand Runemaster Blade inside |",
            "| A dust that, when eaten,  gives those that eat it powerful visions of a fiery lion before them |",
            "| A feather shedded from a rather large bird | Can be sold for 50 Illyn or bartered away |",
            "| A flashy charm with six empty slots | Can be used to combine with an ally for two rounds | Chargedot is consumed | Chargedots gained from killing a target with the Fusionic Whip |",
            "| A foamy drink that, when ingested, allows the drinker to climb up any surface with normal ease | Walls and ceiling become accessible terrain |",
            "| A glossy ruby kept tucked away by those who cherish it | Enchanted by a Wizard to give the holder an additional +5 stamina |",
            "| A gray flower that roots itself into the holder, slowly growing throughout them with no side effects until their death | Upon dying, the flower revives the individual but turns all allies foes and foes into allies |",
            "| A healing cream, capable of sealing an open wound within seconds of applying | Created in Illyria |",
            "| A heavily concocted brew, bolstering the drinker's energy levels | Allows two actions in a turn instead of one |",
            "| A large bottle of warm, restoring brews | Restores 10 stamina to those who drink the mixture |",
            "| A large skull worn by an Orc | Capable of carrying four additional items when worn in a wearing slot |",
            "| A large, aqua-colored staff with a sapphire shrimp on the end | When used, a large shrimp rises from the ground to carry the user |",
            "| A large, solid gold with some sort of reinforcement in place | Pulled from the mouth of an Octovoid within the Limbo |",
            "| A miniature thunderstorm inside a bottle | When released can potentially unleash a powerful storm, raining lightning upon d4 enemies |",
            "| A new invention from the gnomes | A futuristic rocket, capable of firing all the users mana pool as a single attack on a target |",
            "| A pendent that gives the wearer the ability to retain sanity when alone for long amounts of time, created by an Arcanius Elius Wizard for scholarly-usage |",
            "| A pendent with a wonderous, but cracked, crystal in the center | When the Pendent is repaired and worn in a Wearing slot, it grants the wearer immunity to traps |",
            "| A potion that, when thrown upon an area, grants those within the 3x3 an additional +3 to their movement speed | Effects last two turns |",
            "| A powerful mixture, giving the drinker a +5 damage to all attacks for five turns, however, the drinker attacks anything within range (including allies) |",
            "| A rather large potion capable of restoring 10 mana to those who drink it | Makes non-magic users slightly nauseous |",
            "| A ring that, when worn, subconciously prevents the wearer from telling the truth in any scenario | Effects last for an additional two turns after the ring's removal |",
            "| A robotic arm which increases melee damage by two |",
            "| A rough stone, shaped for the hand of a Goblin | Capable of allowing a spell to be cast for stamina instead of mana | Three turn cool down |",
            "| A scale from the ancient dragon, Xennudi, obtained long ago by Ripenoodle Glassenshine | Extremely valuable |",
            "| A small jar of enchanting waters, allowing the holder to enchant an item with a random element |",
            "| A smooth, orange stone with a green rune etched into it | Allows the holder to ask the stamina of a target | Once per combat |",
            "| A special herb crafted by an advanced Alchemist | Restores half stamina anytime |",
            "| A spoon with magical properties | Unable to be destroyed in any way |",
            "| A staff covered in runic language, unable to be read by the common person, with a glowing slot near the top of the staff | The staff is bronze-colored, with piercing stripes of silver near the edges |",
            "| A strong-scented jar with a tightly-wrapped lid | When popped open, the party is refreshed for 10 stamina | ",
            "| A talisman created by Illius, using instructions detailed within the later chapters of the Limbosian Grimoire | Empowers spells casted by the wearer with +2d6 dark |",
            "| A talking book, often allowing the holder to gain incite about a situation | On a 20 enchants the holder's primary weapon with +d6 of any elemental type |",
            "| A throbbing heart that, when ingested, provides the powerful Donkey King Spirit to embue them for three turns | A herd of Donkeys can be called to deal +8d6 | +2d4 to melee attacks |",
            "| A wearable decoration, allowing the user to find additional loot by rolling higher than a 15 | Two turn cooldown | Very fragile |",
            "| A white, chipped ring crafted from fine salt imported from Brinestep | Worn by those at sea for good luck |",
            "| A mailable puddy, created by Pankos, that is quick to burn at high temperatures | When used on a target and ignited, deals 2d4 fire for two turns |",
            "| An advanced rune, forged by magesmiths in Hundlebovia | Binding a spell to a rune allows use without mana cost, however, the holder loses 5 stamina permanently |",
            "| An art-covered vase with a metal lid, fit perfectly to seal the contents inside | Contains infinite water that, when poured out, can quickly flood the local area if not ",
            "| An impressive hat, causing weak-minded individuals to listen to your words |",
            "| An invention of the Gnomes in 150 DP, created to power small mechanisms/creations |",
            "| An item that, when combined with a ranged weapon, adds +2 range (up to 8 range) | Useful for Tinkerers and those with the Craft skill |",
            "| An orb that allows the holder to see through other's lies, with the drawback of being unable to lie themselves |",
            "| Appears to have residue at bottom of chamber | When smoked, the user turns from their current race to dwarf |",
            "| Can never break | Stretches up to twenty feet | A highly-flexible piece of rope, crafted with a mesh fabric to maintain structural integrity |",
            "| Capable of reflecting an incoming spell | If the user rolls over 10, the spell is deflected successfully | If the roll is 15+ the spell is reflected directly at the person who casted the spell | Three uses |",
            "| Coats the holder's inventory from prying hands and eyes | Can be taken on a 20, then the inventory is able to be stolen from |",
            "| Equipment unveiled at the Cowboy Bang Bang Gunshow CLX | When worn gives the wearer the ability to dash instead of walk, allowing 7 moves instead of five | Lifts the user off the ground ever so slightly to reduce tiring |",
            "| Gives the user random sayings that aren't actually saying | Actually speakings in Yondalotion, the dialect of the Gods and understood by few |",
            "| Jars with the souls of ancient Bards, prone to snitching if disturbed | Extremely valuable and fragile, often given as gifts |",
            "| Negates all fall damage | Bright orange with green highlights, very noticeable |",
            "| Points towards the nearest artifact |",
            "| Protects the wearers mind from being controlled or damaged | A light-toned necklace, with a runic cord interlacing between pieces of blessed stone |",
            "| Raises the wearer's AP by one | Single-use item | AP cannot exceed 10 |",
            "| The user gains the ability to regenerate 1 stamina + d4 to an ally each turn |",
            "| The user has steady footing, never having to roll for anything regarding balance |",
            "| The user is able to create puppets out of thin air, giving each a voice and d4 damage | Puppets dissolve out of combat |",
            "| The user learns new recipes for spells |",
            "| The user pulls two common items from a seemingly infinite toolbox | The items expire at the end of combat and no more than two items can be out at once | Consumables must be put back in | RP |",
            "| The user regenerates d4 mana each turn when this cloth is equipped | Only if the wearer reminds the DM | Highly flammable |",
            "| Used by dwarves to ignite forges | Releases an incredibly hot flame, dealing 6 + 2d6 fire to anything within 3 range when it is opened | 2 Use item |",
            "| Wearing these makes the user immune to rough terrain, also gaining +2 to rolls regarding climbing |",
            "| When beaten against a corpse, gold is gained | Add 0 to the end of the roll |",
            "| When consumed causes massive visual hallucinations | Users see themselves sprout butterfly wings and 'fly' around the area | Gathered from rare Butterflies on the West Coast of Aletoria |",
            "| When rubbed on a weapon/tool, the item is coated in a stitching of gold |",
            "| When the wearer has taken 20 damage, the thruster engages and launches them in a direction for 25 range | ",
            "| When thrown, anything within the 3x3 AOE gains +5 shield for the entirety of combat | Can stack up to 15 shield |",
            "| When tinkered, this scope will add +3 to the range of a ranged weapon |",
            "| When worn, the user vanishes into the shadows | If the user attacks a target, the target may be able to find them |",
            "| When worn, the wearer will feel reduced gravitational effects, floating during turns |",
            "| Wine crafted from magic-infused fruit within Illyria | Tastes incredible due to being aged on the bottom of Illyria's shores under heavy magical influence | 100 Illyn |",
            "| Worth 150 Illyn | A diamond cut by a careful jeweler |"}
    Dim Excluded() As String = {"The Pathosblade", "Golden Pistol of Precision", "New-Age Dragon Blade", "Supreme Paladin Armor", "Bronzonite Armor ", "Dragon Steel",
            "Pathonium Armor", "Dragon Scale Armor", "Dragon Scale Battleaxe", "Accelerator Cannon", "Enhanced Longblunder", "Emberslight",
            "Elven Boltbow", "Lover", "Enchanted Bronzonite Glove", "Dragon Blade", "Nightender", "Mirror Battleaxe",
            "Doomsword", "Bronzonite", "Red Laridium Crystal", "Green Laridium Crystal", "Orange Laridium Crystal", "Enchanted Bag of Holding",
            "Blue Laridium Crystal", "Yellow Laridium Crystal", "Purple Laridium Crystal"}
    Dim ExcludedD() As String = {"| - damage | 2 range | A fabled blade from the first days of the Pathosrealm | Said to be the only weapon to gods with a single touch | Deals infinite damage, obliterating anything below a god |",
            "| 10 + 2d6 | 5 range | A pistol once held by Madec of the New Age Brotherhood | User rolls only when an ability can block the attack | Attack rolls with this weapon gain +5 |",
            "| 11 + d6 fire | 4 range | A blade forged from the Father Dragon of Aletoria's scales, deals large damage | Forged within the dragon's still-beating heart |",
            "| 11 AP | 11 MP | A silver-tinted medal armor, worn by Ironside humans capable of carrying the immense weight |",
            "| 12 AP | 11 MP | Only able to wear one layer of armor when equipped |",
            "| 12 AP | 12 AP | Deals +1d4 fire  when an unarmored target attacks | Glows in a 15ft range | Strong armor forged in Artificial Dragonfire at Illyria |",
            "| 13 AP | 13 MP | Godly armor, given to those worthy by the Gods standards | Reduces incoming attacks by 50% (round up) | Bound to wearer |",
            "| 13 AP | 2d4 fire damage for anything that touches the armor besides the wearer |",
            "| 20 + d20 fire | 4 range | A powerful battleaxe, crafted from Dragon Scales | Extremely powerful and rare, sought after by poor and rich alike |",
            "| 25 + 2d6 fire | 10 range, Line | 25 mana | A large cannon crafted by a Gnome genius | Fires a red, heated beam in a long line | Requires a two turn cooldown |",
            "| 5 + 2d6 | 10 range | A tinkered weapon crafted by Lucian's allies | Capable of firing over long distance with deadly consequences | Held by Lucian |",
            "| 6 + d6 fire | 2 range | The user swings a hefty blade towards the target | Named Embersjustice when ignited | Combined greatsword and Grindstone |",
            "| 7 + d4 | 7 range | A powerful bow, crafted to shoot crossbow bolts at arrow speed |",
            "| 7 + d4 light | 3 range | A bronze-coated blade, passed down to Aethur by his father: Eithan Finwald | Supposedly part of a prophecy, though the legend's author is unknown |",
            "| 8 + d4 | 2 range | Artifex is gifted an Enchanted Bronzonite Glove, allowing him to release an enchanting flame upon items | ",
            "| 8 + d4 fire | 3 range | A blade forged from the heart of a dragon | The user feels a pulse of hatred towards the target and swings full force with this lethal blade |",
            "| 8 + d4 light | 3 range | Belonged to Jack, passed down from some of the first paladins | When used, a 3x3 area is filled with moderate light | When used on a dark-arts target will deal +d4 light |",
            "| 8 + d6 | 2 range | When the user is hit by an attack, rolling an 18+ results in the projectile being reflected back at the target | Shimmers like liquid whenever exposed to sunlight |",
            "| 8 + d6 | 3 range | A blade used by the Doomsword Keeper, leader of the Doomsword clan | Any Doomsword-kin that yields this blade can speak to past ancestors of the Doomsword lineage |",
            "| A rare metal only crafted by few | Created in Sturenburrow, only accessible for one week out of the year | Extremely hard to craft with the heat of the Sturenburrow Volcano |",
            "| Called Mawma's Mind | Held/worn by the Village Elder | Double spell damage and turns the player anti-party | Currently in Chimenstone, Delvoria |",
            "| Called the Heart of Illyria | Locked away within Illyria | Used to power the city of Illyria | Grants the holder infinite mana |",
            "| Dimensional Jewel | Allows the user to open a portal anywhere in the world and travel through instantaneously |",
            "| Items are bound to the person who put them in |",
            "| King's Gem | +20 health and double melee damage | A pulsing gem made of Laridium, a cosmic material found only within the gems |",
            "| Resurrection Stone | Resurrect any creature one time |",
            "| Void Crystallix | Held by That | If the user of the stone is bad, they roll d20 damage, if the user is good they heal for d20, and allows extra spell |"}
    Dim Prefix() As String = {"Air", "Antique", "Aquatic", "Arcane", "Blessed", "Charming",
        "Cosmic", "Dark", "Dumpy", "Enlarged", "Feathered", "Fire", "Ghoulish", "Hateful",
        "Ice", "Jury-rigged", "Kinetic", "Leeching", "Lucky", "Mythical", "Overgrown",
        "Pocketed", "Powered", "Scoped", "Shocking", "Silenced", "Terra", "Tinkered",
        "Unfortunate", "Valuable", "Water", "Experienced"}
    Dim PrefixD() As String = {"| A zephyr object that gains +d6 air damage | The item gains more speed, carried by a wind | Can be turned into air and to reappear whenever necessary |",
        "| An antique object, covered in a weathered layer of dust | Must roll above a 10 for the first two uses or the item breaks |",
        "| An aquatic object, crafted with the intent to be used underwater | Damage is increased by +2d4 while underwater |",
        "| An arcane-laced object enchanted to ensure accurate usage | Object only fails on a 1 but is catastrophic when it occurs | +1 accuracy on the object's use |",
        "| A blessed item that gains +d6 light damage | The item gains a lighter hue and glistens when looked upon |",
        "| A charming object that, when used around others, can potentially cause them to become charmed | When given as a gift, the receiver will be greatful |",
        "| A cosmic-ly charged object, fallen from the heavens in a time before now | Gains +3d4 arcane when used | ",
        "| A dark powered object that gains +d6 dark damage | Object is covered in a dark haze that moves away from light |",
        "| A dumpy object, barely held together by a mix of fluids and tape | If used and the roll is below 15, the object will shatter into pieces and fail to work |",
        "| An enlarged object, held by large creatures across the realm | The object gains +d6 to melee damage when used due to it's large size |",
        "| A lightened object, capable of being held with no effort | Can be thrown and will fall at a feather's speed |",
        "| A flaming object that gains +d6 fire damage | The item gains a fiery glow and heats up when used |",
        "| A freightening object, releasing creaks and covered in webs | The object can be used through thin surfaces, passing with no effort |",
        "| An apparently normal object until held, embuing the holder with a hatred of the closest creature | Floods the holder's mind with hateful thoughts and intentions |",
        "| A frosted object that gains +d6 ice damage | The item begins to glisten like ice, slowly converting to an ice-like substance over time |",
        "| A weakly assembled object, barely capable of holding steady | If the roll is below 6, the object falls into two pieces, capable of being rebuilt |",
        "| A modified object capable of releasing extreme kinetic energy, allowing an additional +2d4 for weapons | For movement it provides +4 |",
        "| A cursed item covered in leeches that, when used upon a living target, will leech the foes stamina with each use | Leeches help regain 1 + d4 |",
        "| A twinkling object with a four-leaf clover etched into it | When used, the object can only fail on a 1-2, otherwise it will succeed based on the roll |",
        "| A rumoured object of fabled origin | The object carries immense weight to those that are aware of it's story | The object gains +2 range |",
        "| A dirty and vine-covered object found within the grip of nature | The object must be cleaned before it can be properly used, with a 20 revealing it's true modifier |",
        "| An echanted object, granted a single pocket dimension slot | +1 to inventory | ",
        "| A mechanically-powered object with weightened pieces of metal covering exposed edges | The item can be used with no stamina cost, allowing the user to abuse it properly |",
        "| A modified object, gifted with a scope mounted atop it | Objects incapable of utilizing the scope can utilize the range to extend it's effects across a broad area | Adds +4 range |",
        "| An electrified object, gaining +d6 shocking damage and +1 range | Electricity crackles through the item when used | Gains power when used on a wet target |",
        "| A silenced object, magically enchanted to be muffled from sound | Object can be used at any time in complete silence no matter | ",
        "| An object encased in stone that gains +d6 terra damage | The object gains a hardened layer of stone and can't be broken easily |",
        "| A tinkered object crafted out of bolts and screws | When crafted or tinkered with, the object gains d4 additional +d4 damage | Potential of 4d4 maximum |",
        "| A very unlucky object, prone to jamming and backfiring | If the roll to use the object is below a 5, the item has a 50/50 of backfiring or jamming | Effects can be transferred with the object |",
        "| A glistening object of great value | Worth 3.5x its initial value and can be sold for great wealth | Covered in glowing gems that twinkle in sunlight |",
        "| A fluid object that gains +d6 water damage | The item is covered in a layer of glistening water when used | Grows in size when submerged to gain +2 range |",
        "| A worn in object, capable of being more accurate and effective against targets that it has already been used on | If the roll is 8+, the object succeeds against the target | Gains +d4 when successful |"}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Item As String
        Dim Description As String


        If Q1.Checked = True And A.Checked = True Then
            Name2.Visible = False
            D2.Visible = False
            Prefix1.Visible = False
            Prefix2.Visible = False
            If M.Checked = True Then
                MsgBox("A Modifier cannot be applied to an Artifact")
                M.Checked = False
            End If
            GetItem1(Artifact, ArtifactD, Item, Description)
        End If

        If Q2.Checked = True And A.Checked = True Then
            MsgBox("No.")
        End If

        If Q1.Checked = True And C.Checked = True Then
            Name2.Visible = False
            D2.Visible = False
            Prefix2.Visible = False

            GetItem1(Common, CommonD, Item, Description)
        End If

        If Q2.Checked = True And C.Checked = True Then
            Name2.Visible = True
            D2.Visible = True

            GetItem1(Common, CommonD, Item, Description)
            GetItem2(Common, CommonD, Item, Description)
        End If

        If Q1.Checked = True And U.Checked = True Then
            Name2.Visible = False
            D2.Visible = False
            Prefix2.Visible = False

            GetItem1(Uncommon, UncommonD, Item, Description)
        End If

        If Q2.Checked = True And U.Checked = True Then
            Name2.Visible = True
            D2.Visible = True

            GetItem1(Uncommon, UncommonD, Item, Description)
            GetItem2(Uncommon, UncommonD, Item, Description)
        End If
    End Sub

    Sub GetItem1(ByRef Items() As String, ByRef Description() As String, ByVal Item As String, ByVal ItemDescription1 As String)
        Dim Position As Integer
        Dim Roll As Integer
        Dim Modifier As String
        Position = Math.Ceiling(Rnd() * Items.Length) - 1
        Item = Items(Position)
        ItemDescription1 = Description(Position)
        If M.Checked = True Then
            Roll = Math.Ceiling(Rnd() * 10)
            If Roll <= 2 Then
                Prefix1.Visible = True
                Roll = Math.Ceiling(Rnd() * Prefix.Length) - 1
                Modifier = Prefix(Roll)
                Prefix1.Text = PrefixD(Roll)
            Else
                Prefix1.Visible = False
                Prefix1.Text = ""
            End If
        End If
        Name1.Text = Modifier & " " & Item
        D1.Text = ItemDescription1
    End Sub

    Sub GetItem2(ByRef Items() As String, ByRef Description() As String, ByVal Item As String, ByVal ItemDescription2 As String)
        Dim Position As Integer
        Dim Roll As Integer
        Dim Modifier As String
        Position = Math.Ceiling(Rnd() * Items.Length) - 1
        Item = Items(Position)
        ItemDescription2 = Description(Position)
        If M.Checked = True Then
            Roll = Math.Ceiling(Rnd() * 10)
            If Roll <= 2 Then
                Prefix2.Visible = True
                Roll = Math.Ceiling(Rnd() * Prefix.Length) - 1
                Modifier = Prefix(Roll)
                Prefix2.Text = PrefixD(Roll)
            Else
                Prefix2.Visible = False
                Prefix2.Text = ""
            End If
        End If
        Name2.Text = Modifier & " " & Item
        D2.Text = ItemDescription2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Name1.Text = ""
        Name2.Text = ""
        D1.Text = ""
        D2.Text = ""
        Prefix1.Text = ""
        Prefix2.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Name2.Visible = False
        D2.Visible = False
        Prefix1.Visible = False
        Prefix2.Visible = False
    End Sub

End Class
