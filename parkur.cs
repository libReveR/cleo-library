{$CLEO}
0000: NOP

:main
wait 0
if
    00E1:   key_pressed 0 49 // 1 tuşu
then
    00A0: store_actor $PLAYER_ACTOR position_to 0@ 1@ 2@
    00BA: show_text_styled GXT 'PARKOUR' time 1000 style 1
    0605: actor $PLAYER_ACTOR perform_animation_sequence "RUN_JUMP" IFP_file "PED" 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 // Koşu ve zıplama animasyonu
    wait 1000
    0605: actor $PLAYER_ACTOR perform_animation_sequence "CLIMB" IFP_file "PED" 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 // Tırmanma animasyonu
end
jump @main
