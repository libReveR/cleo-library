{$CLEO}
0000: NOP

:main
wait 0
if
    00DF:   actor $PLAYER_ACTOR driving
then
    if
        00E1:   key_pressed 0 17 // W tuşu
    then
        01B2: give_actor $PLAYER_ACTOR weapon 31 ammo 9999 // M4 silahı
        00A5: $PLAYER_ACTOR perform_animation "CAR_drivebyRHS" IFP_file "PED" 4.0 loop 1 lockX 0 lockY 0 lockF 0 time -1 // Sağdan ateş etme animasyonu
    end
end
jump @main
