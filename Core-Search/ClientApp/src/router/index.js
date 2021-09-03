import { createRouter, createWebHistory } from 'vue-router'
import Search from '@/components/Search.vue'
import Home from '@/components/Home.vue'

const routes = [
    {
        path: "/",
        name: "Home",
        component: Home,
    },
    {
        path: '/search/:searchText?',
        name: 'Search',
        component: Search,
    }
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes
})

export default router
