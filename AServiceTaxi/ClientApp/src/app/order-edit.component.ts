import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { DataService } from './data.service';
import { Order } from './order';
import { Car } from './car';
import { OrderStatus } from './orderStatus';

@Component({
    templateUrl: './order-edit.component.html'
})
export class OrderEditComponent implements OnInit {

    id: number;
    order: Order;
    car: Car;
    freecars: Car[];
    loaded: boolean = false;

    constructor(private dataService: DataService, private router: Router, activeRoute: ActivatedRoute) {
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }

    ngOnInit() {
        if (this.id) {
            this.dataService.getOrder(this.id)
                .subscribe((data: Order) => {
                    this.order = data;
                    if (this.order != null) this.loaded = true;
                    this.dataService.getCars().subscribe((data: Car[]) => {
                        this.freecars = data;
                        this.freecars = this.freecars.filter(c=>c.carReady);
                    });
                });

        }
    }

    saveOrder() {
   /*         this.dataService.getCar(this.order.carID).
                subscribe((data: Car) => {
                    this.car = data;
                    this.car.carReady = true;
                    this.dataService.updateCar(this.car).subscribe(data => console.log("Sucsses. Car is free."));
                });
   */     this.dataService.updateOrder(this.order).subscribe(data => this.router.navigateByUrl("/"));
        this.loaded = false;
    }

    saveOrderWithCar() {
 /*       this.dataService.getCar(this.order.carID).
            subscribe((data: Car) => {
                this.car = data;
                this.car.carReady = false;
                this.dataService.updateCar(this.car).subscribe(data => console.log("Sucsses. Car is reserved!"));
            });
   */     this.dataService.updateOrder(this.order).subscribe(data => this.router.navigateByUrl("/"));
        this.loaded = false;
    }
}