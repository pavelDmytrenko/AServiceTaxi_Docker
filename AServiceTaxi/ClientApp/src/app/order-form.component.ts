import { Component, Input } from '@angular/core';
import { Order } from './order';
@Component({
    selector: "order-form",
    templateUrl: './order-form.component.html'
})
export class OrderFormComponent {
    @Input() order: Order;
}