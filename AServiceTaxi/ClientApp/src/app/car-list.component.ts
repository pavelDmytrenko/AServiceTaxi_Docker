import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { Car } from './car';


@Component({
    templateUrl: './car-list.component.html'
})
export class CarListComponent implements OnInit {

    cars: Car[];
    constructor(private dataService: DataService) { }

    ngOnInit() {
        this.loadCars();
    }
    loadCars() {
        this.dataService.getCars().subscribe((data: Car[]) => this.cars = data);
    }
    deleteCar(id: number) {
        this.dataService.deleteCar(id).subscribe(data => this.loadCars());
    }
}