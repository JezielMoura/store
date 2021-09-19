import adapter from '@sveltejs/adapter-static';

const config = {
	kit: {
		adapter: adapter({ pages: 'dist', assets: 'dist' }),
		target: '#svelte',
        files: {
			assets: 'src/Presentation/assets',
			lib: 'src/Presentation/components',
			routes: 'src/Presentation/pages',
			template: 'src/Presentation/app.html'
		},
		vite: () => ({
			proxy: {
				'/api': {
					 target: 'https://google.com',
					 changeOrigin: true,
					 secure: false,      
					 ws: true,
				 }
			}
		})
	}
};

export default config;
