import { Component } from '@angular/core';
import { Country } from '../../api/locations/country';
import { Region } from '../../api/locations/region';

@Component({
  selector: 'app-locations-home',
  templateUrl: './locations-home.component.html',
  styleUrls: ['./locations-home.component.scss']
})
export class LocationsHomeComponent {
    selectedCountryRegions: Region[] = [];
    selectedCountry: Country = {};
    selectedRegion: Region = {};
    

    onSelectCountry(country: any) {
        this.selectedCountry = country as Country;
        this.selectedCountryRegions = country.regions;
    }

    onSelectRegion(region: any) {
        this.selectedRegion = region as Region;
        console.log(this.selectedRegion);
    }
}
