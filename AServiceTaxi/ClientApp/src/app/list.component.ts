import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { Car } from './car';
import { Order } from './order';
import { OrderStatus } from './orderStatus';


@Component({
    templateUrl: './list.component.html'
})
export class ListComponent implements OnInit {
    cars: Car[];
    freecars: Car[];
    reservedcars: Car[];
    orders: Order[];
    waitingorders: Order[];

    constructor(private dataService: DataService) { }

    ngOnInit() {
        this.loadFreeCars();
        this.loadReservedCars();
        this.loadWaitingOrders();
    }
    loadCars() {
        this.dataService.getCars().subscribe((data: Car[]) => {
            this.cars = data;
        });
    }
    loadFreeCars() {
        this.dataService.getCars().subscribe((data: Car[]) =>{
            this.freecars = data;
            this.freecars = this.freecars.filter(c => c.carReady);
        });
    }
    loadReservedCars() {
        this.dataService.getCars().subscribe((data: Car[]) => {
            this.reservedcars = data;
            this.reservedcars=this.reservedcars.filter(c => c.carReady==false);
        });
    }
    loadOrders() {
            this.dataService.getOrders().subscribe((data: Order[]) => this.orders = data);
    }
    loadWaitingOrders() {
        this.dataService.getOrders().subscribe((data: Order[]) => {
            this.waitingorders = data;
            this.waitingorders = this.waitingorders.filter(o => o.orderStatus == OrderStatus.Waiting);
        });
    }
    deleteCar(id: number) {
        this.dataService.deleteCar(id).subscribe(data => this.loadCars());
    }
    deleteOrder(id: number) {
        this.dataService.deleteOrder(id).subscribe(data => this.loadOrders());
    }
    
}