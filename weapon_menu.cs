{$CLEO}
0000: NOP

:main
wait 0
if
    00E1:   key_pressed 0 49 // 1 tuşu
then
    03E5: show_text_box 'WEAPON_MENU'
    wait 2000
    if
        00E1:   key_pressed 0 49 // 1 tuşu
    then
        01B2: give_actor $PLAYER_ACTOR weapon 22 ammo 9999 // Pistol
    end
    if
        00E1:   key_pressed 0 50 // 2 tuşu
    then
        01B2: give_actor $PLAYER_ACTOR weapon 25 ammo 9999 // Shotgun
    end
    if
        00E1:   key_pressed 0 51 // 3 tuşu
    then
        01B2: give_actor $PLAYER_ACTOR weapon 30 ammo 9999 // AK-47
    end
    if
        00E1:   key_pressed 0 52 // 4 tuşu
    then
        01B2: give_actor $PLAYER_ACTOR weapon 31 ammo 9999 // M4
    end
    if
        00E1:   key_pressed 0 53 // 5 tuşu
    then
        01B2: give_actor $PLAYER_ACTOR weapon 34 ammo 9999 // Sniper
    end
end
jump @main
