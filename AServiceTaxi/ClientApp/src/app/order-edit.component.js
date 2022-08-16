var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { Component } from '@angular/core';
let OrderEditComponent = class OrderEditComponent {
    constructor(dataService, router, activeRoute) {
        this.dataService = dataService;
        this.router = router;
        this.loaded = false;
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }
    ngOnInit() {
        if (this.id) {
            this.dataService.getOrder(this.id)
                .subscribe((data) => {
                this.order = data;
                if (this.order != null)
                    this.loaded = true;
                this.dataService.getCars().subscribe((data) => {
                    this.freecars = data;
                    this.freecars = this.freecars.filter(c => c.carReady);
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
        */ this.dataService.updateOrder(this.order).subscribe(data => this.router.navigateByUrl("/"));
        this.loaded = false;
    }
    saveOrderWithCar() {
        /*       this.dataService.getCar(this.order.carID).
                   subscribe((data: Car) => {
                       this.car = data;
                       this.car.carReady = false;
                       this.dataService.updateCar(this.car).subscribe(data => console.log("Sucsses. Car is reserved!"));
                   });
          */ this.dataService.updateOrder(this.order).subscribe(data => this.router.navigateByUrl("/"));
        this.loaded = false;
    }
};
OrderEditComponent = __decorate([
    Component({
        templateUrl: './order-edit.component.html'
    })
], OrderEditComponent);
export { OrderEditComponent };
//# sourceMappingURL=order-edit.component.js.map