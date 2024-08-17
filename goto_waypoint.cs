{$CLEO}
0000: NOP

:main
wait 0
if
    00E1:   key_pressed 0 120 // F9 tuşu
then
    if
        00DF:   actor $PLAYER_ACTOR driving
    then
        00A0: store_actor $PLAYER_ACTOR position_to 0@ 1@ 2@
        00A1: put_car $PLAYER_ACTOR current_car at 0@ 1@ 2@
        00A5: 3@ = create_car #INFERNUS at 0@ 1@ 2@
        00AB: put_actor $PLAYER_ACTOR into_car 3@
        00BA: show_text_styled GXT 'CAR_CREATED' time 1000 style 1
    end
end
jump @main
