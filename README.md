# X-tocka
Proekt igra X-tocka 
allButtonClicks - funkcija za sekoe od 9-te polinja za igra, go regulira redosledot, proveruva pobednik i neresheno. ;; 
Winner() - se pravi proverka (horizontalna, vertikalna i dijagonalna) dali imame tri posledovatelni X ili O i vrakja true ili false. ;; 
isDraw() - ja proveruva turn promenlivata dali stasala do 9, no i Winner() dali e false za da bide neresheno, vo sprotivno imame pobednik. ;; 
newGame() - prethodnite rezultati se kopiraat, se praznat polinjata i se resetira brojot na odigrani potezi(0). ;; 
ResetButton_Click() - pobedite na X i O, kako i neresheniot rezultat se setiraat na nula i se povikuva i newGame() f-jata za da ne se povtoruva istiot kod za praznenje na polinjata i resetiranje na redosledot.
