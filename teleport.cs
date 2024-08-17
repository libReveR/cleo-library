{$CLEO}
0000: NOP

:main
wait 0
if
    00E1:   key_pressed 0 49 // 1 tuşu
then
    03E5: show_text_box 'TELEPORT_MENU'
    wait 2000
    if
        00E1:   key_pressed 0 49 // 1 tuşu
    then
        00A0: store_actor $PLAYER_ACTOR position_to 0@ 1@ 2@
        00A1: put_actor $PLAYER_ACTOR at 0@ 1@ 2@
        00BA: show_text_styled GXT 'TELEPORTED' time 1000 style 1
    end
    if
        00E1:   key_pressed 0 50 // 2 tuşu
    then
        00A0: store_actor $PLAYER_ACTOR position_to 0@ 1@ 2@
        00A1: put_actor $PLAYER_ACTOR at 1500.0 -1500.0 13.0 // Belirli bir konuma teleport
        00BA: show_text_styled GXT 'TELEPORTED' time 1000 style 1
    end
end
jump @main
