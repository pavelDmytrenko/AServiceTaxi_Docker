import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from './data.service';
import { Order } from './order';
import { OrderStatus } from './orderStatus';

@Component({
    templateUrl: './order-create.component.html'
})
export class OrderCreateComponent {

    order: Order = new Order();

    constructor(private dataService: DataService, private router: Router) { }
    saveOrder() {
        this.order.orderStatus = OrderStatus.InProgress;
        this.dataService.createOrder(this.order).subscribe(data => this.router.navigateByUrl("/"));
    }
}