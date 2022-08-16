import { Component, Input } from '@angular/core';
import { Order } from './order';
import { Car } from './car';
@Component({
    selector: "order-form-car",
    templateUrl: './order-form-car.component.html'
})
export class OrderFormCarComponent {
    @Input() order: Order;
    @Input() freecars: Car[];

}