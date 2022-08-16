import { Car } from './car';
export class Order {
    constructor(
        public orderId?: number,
        public orderDate?: Date,
        public orderComplateDate?: Date,
        public orderAddressSource?: string,
        public orderAddressDestination?: string,
        public orderStatus?: number,
        public carID?: number    ) { }
}