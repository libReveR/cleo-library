{$CLEO}
0000: NOP

:main
wait 0
if
    00E1:   key_pressed 0 70 // F tuşu
then
    00A0: store_actor $PLAYER_ACTOR position_to 0@ 1@ 2@
    00A1: put_actor $PLAYER_ACTOR at 0@ 1@ 2@
    00BA: show_text_styled GXT 'FLY_MODE' time 1000 style 1
    0605: actor $PLAYER_ACTOR perform_animation_sequence "FLY" IFP_file "PED" 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 // Uçma animasyonu
end
jump @main
