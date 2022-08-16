import { Component, Input } from '@angular/core';
import { Order } from './order';
@Component({
    selector: "order-form-complate",
    templateUrl: './order-form-complate.component.html'
})
export class OrderFormComplateComponent {
    @Input() order: Order;
}