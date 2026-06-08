local gildedBerry = {}
gildedBerry.name = "ElegiacHelper/GildedBerry"
gildedBerry.depth = -100
gildedBerry.texture = "collectables/goldberry/idle00"
gildedBerry.justification = {0.5, 1.0}
gildedBerry.fieldInformation = {
	deathsRemaining = {
		fieldType = "integer"
	}
}
gildedBerry.placements = {
    name = "gilded_berry",
	data = {
		deathsRemaining = 2
	}
}
return gildedBerry