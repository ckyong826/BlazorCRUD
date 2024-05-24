self.addEventListener('fetch', event => {
    if (event.request.method === 'POST') {
        event.respondWith(
            fetch(event.request).catch(() => {
                return event.request.json().then(body => {
                    savePostRequest({ url: event.request.url, body });
                    return new Response(
                        JSON.stringify({ error: 'Request saved for retry.' }),
                        { headers: { 'Content-Type': 'application/json' } }
                    );
                });
            })
        );
    }
});

self.addEventListener('sync', event => {
    if (event.tag === 'sync-post-requests') {
        event.waitUntil(
            getPostRequests().then(requests => {
                return Promise.all(requests.map(request => {
                    return fetch(request.url, {
                        method: 'POST',
                        body: JSON.stringify(request.body),
                        headers: {
                            'Content-Type': 'application/json'
                        }
                    }).then(response => {
                        if (response.ok) {
                            deletePostRequest(request.id);
                        }
                    });
                }));
            })
        );
    }
});
