var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { Component } from '@angular/core';
import { OrderStatus } from './orderStatus';
let ListComponent = class ListComponent {
    constructor(dataService) {
        this.dataService = dataService;
    }
    ngOnInit() {
        this.loadFreeCars();
        this.loadReservedCars();
        this.loadWaitingOrders();
    }
    loadCars() {
        this.dataService.getCars().subscribe((data) => {
            this.cars = data;
        });
    }
    loadFreeCars() {
        this.dataService.getCars().subscribe((data) => {
            this.freecars = data;
            this.freecars = this.freecars.filter(c => c.carReady);
        });
    }
    loadReservedCars() {
        this.dataService.getCars().subscribe((data) => {
            this.reservedcars = data;
            this.reservedcars = this.reservedcars.filter(c => c.carReady == false);
        });
    }
    loadOrders() {
        this.dataService.getOrders().subscribe((data) => this.orders = data);
    }
    loadWaitingOrders() {
        this.dataService.getOrders().subscribe((data) => {
            this.waitingorders = data;
            this.waitingorders = this.waitingorders.filter(o => o.orderStatus == OrderStatus.Waiting);
        });
    }
    deleteCar(id) {
        this.dataService.deleteCar(id).subscribe(data => this.loadCars());
    }
    deleteOrder(id) {
        this.dataService.deleteOrder(id).subscribe(data => this.loadOrders());
    }
};
ListComponent = __decorate([
    Component({
        templateUrl: './list.component.html'
    })
], ListComponent);
export { ListComponent };
//# sourceMappingURL=list.component.js.map